using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csvLineSkipper
{
    public class DragDropManager
    {
        //Managing class for drag dropping files into the form.

        public string fileLoc = string.Empty;
        
        /// <summary>
        /// Gets file from drag location and returns file path
        /// </summary>
        /// <param name="e"></param>
        /// <returns>string file path location</returns>
        public string dragDropGetFileName(DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));//gets string array of data properties
                    var filePathString = filePaths[0].ToString(); //converts contents of first array point to string, which is the file's location
                    return filePathString; //returns file path as string
                }
                else return "No File Name Avaliable"; //shouldn't really hit this without triggering an exception

            }
            catch (Exception ex)
            {
                string errMessage = "There was an error reading file";
                MessageBox.Show(errMessage + " " + ex.ToString());
                return errMessage;
            }
        }

        /// <summary>
        /// triggers and checks for valid file that has entered view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DragEnterCapture(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


    }
}
