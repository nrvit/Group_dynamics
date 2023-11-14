using System.Text;

namespace GrDik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnButtonSelectClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary Files|*.bin";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ProcessBinaryFile(filePath);
            }
        }

        private void ProcessBinaryFile(string filePath)
        {
            Dictionary<byte, int> byteFrequency = new Dictionary<byte, int>();

            using (FileStream fileStream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    for (int i = 0; i < bytesRead; i++)
                    {
                        byte currentByte = buffer[i];
                        if (byteFrequency.ContainsKey(currentByte))
                        {
                            byteFrequency[currentByte]++;
                        }
                        else
                        {
                            byteFrequency[currentByte] = 1;
                        }
                    }
                }
            }

            // Отобразите результаты в RichTextBox или другом элементе управления
            richTextBoxResult.Clear();
            foreach (var entry in byteFrequency)
            {
                richTextBoxResult.AppendText($"Byte 0x{entry.Key:X2}: Вхождений: {entry.Value}\n");
            }
        }

        private void buttonCreateFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary Files|*.bin";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                string fileContent = textBoxFileContent.Text; // Получаем содержимое из TextBox

                // Преобразуйте строку в байты и сохраните их в файл
                byte[] bytes = Encoding.UTF8.GetBytes(fileContent);
                File.WriteAllBytes(filePath, bytes);
                MessageBox.Show("Бинарный файл создан.");
            }
        }
    }
}