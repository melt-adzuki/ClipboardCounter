using System.Runtime.InteropServices;

namespace ClipboardCounter;

public partial class CounterForm : Form
{
    public CounterForm()
    {
        InitializeComponent();
    }

    private bool IsAdditionMode => additionModeCheckBox.Checked;

    private int _counter;
    private int Counter
    {
        get => _counter;
        set
        {
            _counter = value;
            counterLabel.Text = _counter.ToString();
        }
    }

    [LibraryImport("user32.dll")]
    private static partial void AddClipboardFormatListener(IntPtr hWnd);

    [LibraryImport("user32.dll")]
    private static partial void RemoveClipboardFormatListener(IntPtr hWnd);

    protected override void WndProc(ref Message m)
    {
        const int wmClipboardUpdate = 0x31D;

        if (m.Msg == wmClipboardUpdate)
        {
            OnClipboardUpdate();
            m.Result = IntPtr.Zero;
        }
        else base.WndProc(ref m);
    }

    private void OnClipboardUpdate()
    {
        var text = Clipboard.GetText().Trim();
        var length = text.Length;

        if (IsAdditionMode) Counter += length;
        else Counter = length;
    }

    private void CounterForm_Load(object sender, EventArgs e)
    {
        AddClipboardFormatListener(Handle);
    }

    private void CounterForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        RemoveClipboardFormatListener(Handle);
    }
}
