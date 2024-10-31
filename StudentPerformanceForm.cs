namespace PW5SPP;

public partial class StudentPerformanceForm : Form
{
    private readonly string _filePath = @"C:\Users\vlad\Desktop\Study\Subjets\OAiP_(C#)\CsharpSystemProgrammingPracticum\PW5SPP\TextFiles\TestFile.txt";

    public StudentPerformanceForm() => InitializeComponent();

    private void StudentPerformanceForm_Load(object sender, EventArgs e)
    {
        Text = "Успеваемость студента";
        SerialNumberLabel.Text = "Порядковый номер";
        FullNameLabel.Text = "Фамилия И.О.";
        AverageMarkLabel.Text = "Средний балл";

        SerialNumber.Clear();
        FullName.Clear();
        AverageMark.Clear();

        ReadButton.Text = "Читать";
        SaveButton.Text = "Сохранить";
    }

    private void ReadButton_Click(object sender, EventArgs e)
    {
        if (!File.Exists(_filePath))
            return;

        BinaryReader reader = new(File.OpenRead(_filePath));

        try
        {
            var serialNumber = reader.ReadInt32();
            string? fullName = reader.ReadString();
            float averageMark = reader.ReadSingle();

            SerialNumber.Text = Convert.ToString(serialNumber);
            FullName.Text = Convert.ToString(fullName);
            AverageMark.Text = Convert.ToString(averageMark);
        }
        finally
        {
            reader.Close();
        }
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        BinaryWriter writer = new(File.Open(_filePath, FileMode.Create));

        try
        {
            int serialNumber = Convert.ToInt32(SerialNumber.Text);
            string? fullName = Convert.ToString(FullName.Text);

            AverageMark.Text = AverageMark.Text.Replace(".", ",");

            float averageMark = Convert.ToSingle(AverageMark.Text);


            writer.Write(serialNumber);
            writer.Write(fullName);
            writer.Write(averageMark);
        }
        finally
        {
            writer.Close();
        }
    }
}
