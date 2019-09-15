using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Text_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Open s file..";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                using (StreamReader sr = new StreamReader(openFile.FileName))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
            } 
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save file as..";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                {
                    sw.Write(richTextBox1.Text);
                    sw.Close();
                }
            }
        }

        private void CutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void CopyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void PasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripButton.PerformClick();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openToolStripButton.PerformClick();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripButton.PerformClick();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoButton.PerformClick();
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redoButton.PerformClick();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutToolStripButton.PerformClick();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripButton.PerformClick();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasteToolStripButton.PerformClick();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectAllButton.PerformClick();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
