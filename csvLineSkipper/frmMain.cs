using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace csvLineSkipper
{
    public partial class frmMain : Form
    {
        DragDropManager ddm = new DragDropManager(); //creates new instance of class DragDropManager
        string fileLoc = string.Empty;
        

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //setup to allow drag drop manager to work
            this.AllowDrop = true;
            this.DragEnter += frmMain_DragEnter;
            this.DragDrop += frmMain_DragDrop;                    
        }

        /// <summary>
        /// Event for drag drop capture of file location, passing method from DragDropManager class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {          
            fileLoc = ddm.dragDropGetFileName(e); //captures string return of file path location
            lblFileLocation.Text = fileLoc; //passes file location to the display label, which allows it to be read as string without DragEventArgs
            
        }

        /// <summary>
        /// Event for drag drop to trigger prelim when file is dragged into bounds of form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            ddm.DragEnterCapture(sender, e);           
        }

        /// <summary>
        /// Opens a reader and reads each line of the file, saving each line to a string array.
        /// </summary>
        /// <param name="fileLocation">File to be read</param>
        /// <param name="splitChar">char in order to split file, default is ',' </param>
        /// <returns>List of string[] containing each line of the file</returns>
        public List<string[]> readFile(string fileLocation, char splitChar =',')
        {
            try
            {
                StreamReader reader = new StreamReader(fileLocation); //stream reader to read lines of the file, might not be the most efficient way to do it, but it's my most comfortable.

                var lines = new List<string[]>(); // makes a new list of string arrays, each entry in the list is a line of from the reader, and each entry in the string[] 

                while (!reader.EndOfStream)
                {
                    //this array is for each line of the file, because I'm currently working a lot with csvs. However with the passed char it could also be used for any single char regex needs
                    string[] Line = reader.ReadLine().Split(splitChar);
                    lines.Add(Line); //adds the array to a section in the list.
                }

                return lines; //returns list of string[], each containing a line of the file.
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured while reading the file" + ex.ToString());
                return null;
            }
        }

        /// <summary>
        /// Takes list from readFile, and cherry picks data for return
        /// </summary>
        /// <param name="fileLoc">location of file to be read</param>
        /// <param name="arrayPointOne">Optional: choice in specific point of array array[arrayPointOne][arrayPointTwo]</param>
        /// <param name="arrayPointTwo">Optional: choice in specific point of array array[arrayPointOne][arrayPointTwo]</param>
        /// <returns>string of chosen data from array points</returns>
        public string[] collectSpecificFromFile(string fileLoc, int arrayPointOne = 0, int arrayPointTwo = 0)
        {
            try
            {
                var outputContents = readFile(fileLoc);
                var collectedData = new List<string>(); //makes a new list to store 
                            
                var getData = outputContents[arrayPointOne][arrayPointTwo].ToString();
                collectedData.Add(getData);
                return collectedData.ToArray();
                               
            }
            catch (Exception ex)
            {
                string errMessage = "There was an error returning this record";
                MessageBox.Show( errMessage+" "+ ex.ToString());
                return null;
                
            }
        }

        /// <summary>
        /// Takes list from readFile, and cherry picks data for return, and continues pulling at a set interval
        /// </summary>
        /// <param name="fileLoc">Location of file to be read</param>
        /// <param name="arrayPointOne">Optional: choice in specific point of array array[arrayPointOne][arrayPointTwo]</param>
        /// <param name="arrayPointTwo">Optional: choice in specific point of array array[arrayPointOne][arrayPointTwo]</param>
        /// <param name="jumpCount">Set to jump increase in ArrayPointOne</param>
        /// <returns>string of chosen data from array points</returns>
        public string[] collectSpecificFromFile(string fileLoc, int jumpCount, int arrayPointOne = 0, int arrayPointTwo = 0)
        {
            try
            {
                var outputContents = readFile(fileLoc);
                List<string> collectedData = new List<string>();

                txtOutput.Text += "=======Collected Data:=======\r\n";
                int arrayOneJump = arrayPointOne;

                for (int i = arrayPointOne; i < outputContents.Count; i=i+jumpCount)
                {                   
                    var getData = outputContents[arrayOneJump][arrayPointTwo].ToString();
                    collectedData.Add(getData);
                    arrayOneJump = arrayOneJump + jumpCount;
                }

                return collectedData.ToArray();
            }
            catch (Exception ex)
            {
                string errMessage = "There was a error returning this record";
                MessageBox.Show(errMessage + ' ' + ex.ToString());
                return null;
                
            }
        }

        /// <summary>
        /// Presents display collected data to the txtOutput window.
        /// </summary>
        /// <param name="dataset"></param>
        public void displayCollectedData(string[] dataset, int jumpCount, int arrayPointOne, int arrayPointTwo)
        {
            //currently only displays the collectSpecificFromFile contents, as that's all I really want at the moment.
            //TODO add switchable option control

            try
            {
                var collection = collectSpecificFromFile(fileLoc, jumpCount, arrayPointOne, arrayPointTwo);

                foreach (var item in collection)
                {
                    txtOutput.AppendText(item.ToString()+"\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error" + ex.ToString());
                
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //get values from UI components
            fileLoc = lblFileLocation.Text; //gets file location as string from label after DragDrop  
            
            int arrayPointOne = (int)nudArrayValueOne.Value;
            int arrayPointTwo = (int)nudArrayValueTwo.Value;
            int counterValue = (int)nudCounter.Value;

            bool ischkCounter = chkCounter.Checked;
            var collectedDataCounter = collectSpecificFromFile(fileLoc, arrayPointOne, arrayPointTwo, counterValue);

            displayCollectedData(collectedDataCounter, counterValue, arrayPointOne, arrayPointTwo);
            
        }

        /// <summary>
        /// Turns nudCounter readonly true or false, based on checkbox toggle.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCounter_CheckedChanged(object sender, EventArgs e)
        {
            //TODO set this up properly, right now it's unused.
            if (nudCounter.ReadOnly == true)
            {
                nudCounter.ReadOnly = false;
            }
            else nudCounter.ReadOnly = true;

        }
    }
}
