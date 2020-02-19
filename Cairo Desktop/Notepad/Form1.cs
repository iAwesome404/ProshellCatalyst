using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        String currentFile;
        ArrayList undoList;
        ArrayList redoList;
        int textSizeValue;
        public Form1()
        {
            InitializeComponent();
            currentFile = null;
            undoList = new ArrayList();
            redoList = new ArrayList();
            undoList.Add("");
            undoBtn.Enabled = false;
            undoToolStripMenuItem.Enabled = false;

            redoBtn.Enabled = false;
            redoToolStripMenuItem.Enabled = false;

            textSizeValue = 10;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }
        private void openFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFile = openFileDialog1.FileName;
                System.IO.StreamReader sr = new System.IO.StreamReader(currentFile);
                
                textBox1.Text = sr.ReadToEnd();
                //enable save and print option
                saveBtn.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
                printBtn.Enabled = true;
                printToolStripMenuItem.Enabled = true;
                this.Text = currentFile + " Notepad"; 
                sr.Close();
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileAs();
        }

        private void saveFileAs()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFile = saveFileDialog1.FileName;
                this.Text = currentFile + " Notepad";
                saveFile();
            }
            saveBtn.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            printBtn.Enabled = true;
            printToolStripMenuItem.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveFile()
        {
            System.IO.StreamWriter wr = new System.IO.StreamWriter(currentFile);

            wr.Write(textBox1.Text);
            wr.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void newFile()
        {
            DialogResult result = MessageBox.Show("Do you want to save changes to the current file?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (currentFile != null)
                    saveFile();
                else
                    saveFileAs();
            }
            else if (result == DialogResult.Cancel)
            {
                //code for Cancel
                return;
            }
            textBox1.Text = "";
            saveBtn.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
            printBtn.Enabled = false;
            printToolStripMenuItem.Enabled = false;
            currentFile = null;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?\n All the current changes will be lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                //code for Cancel
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int numOfLines = textBox1.Lines.Length;
            lineNumber.Text = "";
            for (int i = 0; i != numOfLines; ++i)
                lineNumber.AppendText((i + 1) + "\n");
            linesLabel.Text = numOfLines.ToString();
            lengthLabel.Text = textBox1.Text.Length.ToString();
            undoBtn.Enabled = true;
            undoToolStripMenuItem.Enabled = true;
            undoList.Add(textBox1.Text);

            printBtn.Enabled = true;
            printToolStripMenuItem.Enabled = true;
            
           
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
            
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void cutBtn_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pastebtn_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find();
        }
        private void findBtn_Click(object sender, EventArgs e)
        {
            Find();
        }
        private void Find()
        {
            findForm f1 = new findForm();
            f1.ShowDialog();
            if (f1.getFindWord() != "")
            {
                
                int index = 0;
                while (index != -1 && index < textBox1.Text.Length)
                {
                    // Searches the text in a RichTextBox control for a string within a range of text withing the control and with specific options applied to the search.
                    index = textBox1.Text.IndexOf(f1.getFindWord(), index);
                    if (index != -1)
                    {
                        textBox1.Select(index, f1.getFindWord().Length);
                        // After a match is found the index is increased so the search won't stop at the same match again. This makes possible to highlight same words at the same time.
                        index++;
                        f1.ShowDialog();
                    }
                }
            }
            MessageBox.Show("End of file","End of file");

        }

        private void finToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replace();
        }

        private void replace_Click(object sender, EventArgs e)
        {
            Replace();
        }
        private void Replace()
        {
            replaceForm r1 = new replaceForm();
            r1.ShowDialog();
            String findWord = r1.findWord;
            String replaceWord = r1.replaceWord;
            if (findWord != "")
            {
                textBox1.Text = textBox1.Text.Replace(findWord, replaceWord);
                MessageBox.Show("Done", "Done", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Nothing to replace", "Done", MessageBoxButtons.OK);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myUndo();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            myUndo();
        }

        private void myUndo()
        {
            //adding current text to redo
            redoList.Add(textBox1.Text);
            redoBtn.Enabled = true;
            redoToolStripMenuItem.Enabled = true;
            //get last change and set text in text box
            textBox1.Text = (String)undoList[undoList.Count - 2];
            undoList.RemoveAt(undoList.Count - 1);
            
            undoList.RemoveAt(undoList.Count - 1);

            if (undoList.Count == 1)
            {
                undoBtn.Enabled = false;
                undoToolStripMenuItem.Enabled = false;
            }
            

        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            myRedo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myRedo();
        }
        private void myRedo()
        {
            textBox1.Text = (String)redoList[redoList.Count - 1];
            redoList.RemoveAt(redoList.Count-1);
            if (redoList.Count == 0)
            {
                redoBtn.Enabled = false;
                redoToolStripMenuItem.Enabled = false;
            }

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = currentFile;
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            //Call ShowDialog
            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
           
                
        }

        private void fontBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(fontBox.SelectedItem.ToString(),textSizeValue);
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textSizeValue = int.Parse(sizeBox.SelectedItem.ToString());
            textBox1.Font = new Font(fontBox.SelectedItem.ToString(), textSizeValue);
            lineNumber.Font = new Font(fontBox.SelectedItem.ToString(), textSizeValue);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shortcuts for notepad \n  ctrl+n - new file\n  ctrl+o - open file\n  ctrl+p - print file\n  ctrl+e - exit\n  ctrl+f - find\n  ctrl+r - replace\n  f1 - help\n", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void releaseNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1. Graphic user interface in WinForms\r\n" +
                             "       a. Fereastra principala\r\n" +
                             "       b. Meniu File cu submeniu: Open, Save, Save As, Close\r\n" +
                             "       c. Meniu Edit cu submeniu: Find, Find & Replace, Undo, Redo\r\n" +
                             "       d. Tool bar care dubleaza functionalitatile din punctul \r\n" +
                             "       e. La modificarea dimensiunilor ferestrei controalele din toolbar raman ancorate la partea stanga\r\n" +
                             "          in timp ce textboxul isi modifica dimensiunea impreuna cu fereastra.\r\n" +
                            "2. Find, Find & Replace\n"+
                             "       a. Se folosesc doua ferestre suplimentare similar cu programul notepad.exe din windows.\r\n" +
                            "3. Daca fisierul a fost modificat se cere o confirmare inainte de inchidere.\r\n" +
                            "4. Functia Undo Redo se implementeaza manual. Numarul de undo’uri – nelimitat.\r\n" +
                            "5. Sa fie respectat tab orderul controalelor.\r\n" +

                            "Добавлено\r\n" +
                                "       1. Возможность выбора шрифта из 4 шрифтов для отображения текста\r\n" +
                                "       2. Изменения размера шрифта.\r\n" +
                                "       3. В меню файл добавлен пункт \"Печать\". (но не знаю, будет ли реально что-то печататься)\r\n" +
                                "       4. Добавленна нумерация строк.\r\n" +
                                "       5. В строке состояния отображается число строк текущего документа и число символов.\r\n" +
	                            "       6. Меню \"About\" где можно открыть Help - набор горячих клавиш,  Release Notes - открытие данного документа.r\n";
           
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
