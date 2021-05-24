using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LexicalAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*          
         *          L e x i c a l  A n a l a y z e r

                              Arian Navabi

            Tehran Gharb University, Compiler Design, Dr.Najari

        */



        /// <summary>
        /// This is the MAIN function of the code.
        /// All of the processes are done in this function & this function calls other child functions as well.
        /// The UI components will call this function to run the algorithm.
        /// </summary>
        void AnalyzeCode()
        {
            // Read Users Given Code From Textbox:
            string[] inputCode = new string[textBox_Input.Lines.Length];
            for (int i = 0; i < textBox_Input.Lines.Length; i++)
            {
                inputCode[i] = textBox_Input.Lines[i];
            }
            richTextBox_Input.Text = textBox_Input.Text;
            //

            // Process The Code:
            int blankCount = 0;
            int operatorCount = 0;
            int idCount = 0;
            int floatCount = 0;
            int intCount = 0;
            string errors = "";
           

            for (int i = 0; i < inputCode.Length; i++) // Each line is analyzed seperatly, & will be summed with the past lines.
            {
                bool[] errorChecklist = new bool[inputCode[i].Length]; // The deafult value for new bool is False, we asume errors as False & scanned characters as True.


                // Each declared grammar is analyzed by a specified function,
                // the functions will return the count of found grammars
                // & will also mark detected grammars as true, in the error checklist:

                blankCount += CountBlankSpaces(inputCode[i], errorChecklist, i);
                operatorCount += CountOperators(inputCode[i], errorChecklist, i);
                idCount += CountIDs(inputCode[i], errorChecklist, i);
                floatCount += CountFloats(inputCode[i], errorChecklist, i);
                intCount += CountInts(inputCode[i], errorChecklist, i);

                errors += ReportErrors(inputCode[i], errorChecklist, i);
            }
            //

            // Print The result:
            string outputText = "";
            outputText += "\r\nBlank Characters:\t" + blankCount.ToString();
            outputText += "\r\nOperator Characters:\t" + operatorCount.ToString();
            outputText += "\r\nID Words:\t\t" + idCount.ToString();
            outputText += "\r\nFloat Numbers:\t\t" + floatCount.ToString();
            outputText += "\r\nInteger Numbers:\t" + intCount.ToString();

            if (errors == "")
            {
                outputText += "\r\n\r\nNo Errors found.\r\n" + errors;
            }
            else
            {
                outputText += "\r\n\r\nErrors:\r\n" + errors;
            }

            Print(outputText);
            //
        }



        #region Algorithm Codes


        /// <summary>
        /// This function counts the blank characters (spaces or tabs) in a given string.
        /// </summary>
        /// <param name="inputLine">String of code that may include blank spaces.</param>
        /// <returns>The count of blank characters.</returns>
        int CountBlankSpaces(string inputLine, bool[] errorChecklist, int lineIndex)
        {
            char[] inputChars = inputLine.ToCharArray();
            int blanksCount = 0;

            for (int i = 0; i < inputChars.Length; i++)
            {
                if (inputChars[i] == ' ' || inputChars[i] == '\t')
                {
                    blanksCount++;
                    errorChecklist[i] = true;
                    HighlightText(i, lineIndex, blankColor);
                }
            }
            return blanksCount;
        }


        /// <summary>
        /// This function counts the operator characters in a given string.
        /// </summary>
        /// <param name="inputLine"></param>
        /// <returns>Count of the operators detected</returns>
        int CountOperators(string inputLine, bool[] errorChecklist, int lineIndex)
        {
            char[] inputChars = inputLine.ToCharArray();
            int operatorCount = 0;

            char[] operatorDictionary = { '+', '-', '=', '<', '>', '/', '*' };

            for (int i = 0; i < inputChars.Length; i++) // Loops on input code
            {
                for (int j = 0; j < operatorDictionary.Length; j++) // Loops on dictionary
                {
                    if (inputChars[i] == operatorDictionary[j])
                    {
                        operatorCount++;
                        errorChecklist[i] = true;
                        HighlightText(i, lineIndex, operatorColor);
                    }
                }
            }
            return operatorCount;
        }



        /// <summary>
        /// This function counts the ID words in a given string, based on its dictionary.
        /// </summary>
        /// <param name="inputLine">String of code that may include IDs spaces.</param>
        /// <returns>The count of blank characters.</returns>
        int CountIDs(string inputCodeString, bool[] errorChecklist, int lineIndex)
        {
            char[] inputCodeChars = inputCodeString.ToCharArray();
            char[] idStartDictionary = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray(); // Numbers & underline isn't allowed for the beggining
            char[] idMidDictionary = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_".ToCharArray();
            int idCount = 0;

            for (int i = 0; i < inputCodeChars.Length; i++)
            {
                bool isIdFound = false;

                // Check for the beggining of an ID:
                for (int j = 0; j < idStartDictionary.Length; j++)
                {
                    if (inputCodeChars[i] == idStartDictionary[j])
                    {
                        idCount++;
                        isIdFound = true;
                        errorChecklist[i] = true;
                        HighlightText(i, lineIndex, idColor);
                        i++;
                        break;
                    }
                }

                // If an ID is found, check for it's length:
                while (i < inputCodeChars.Length && isIdFound)
                {
                    for (int j2 = 0; j2 < idMidDictionary.Length; j2++)
                    {
                        if (inputCodeChars[i] == idMidDictionary[j2])
                        {
                            errorChecklist[i] = true;
                            HighlightText(i, lineIndex, idColor);
                            break;
                        }
                        if (j2 == idMidDictionary.Length - 1)
                        {
                            isIdFound = false;
                            i--;
                        }
                    }
                    i++;
                }

            }
            return idCount;
        }

        /// <summary>
        /// This function counts the float numbers a given string. The function SHOULD be called after CountID() function to work properly.
        /// </summary>
        /// <param name="inputLine">String of code that may include float numbers.</param>
        /// <returns>The count of floar numbers.</returns>
        int CountFloats(string inputLine, bool[] errorChecklist, int lineIndex)
        {
            char[] inputChars = inputLine.ToCharArray();
            char[] numbersDictionary = "0123456789".ToCharArray();
            int floatsCount = 0;

            bool isNumberStartFound = false;    // True when we are meeting a continuous number
            bool isCharNotANumber = false;      // True when a non-number character is met, it is used to check if we met a period later
            bool isPeriodFound = false;         // True when a period is met right after a number. The above flags should be true or else this flag wont be true
            bool isSecondNumberFound = false;   // True when a continous number is found after a continious number & a period. The above flags should be true or else this flag wont be true.
            bool isEndOfFloatFound = false;     // True when an unwanted character is met or the end of the string searching is met, after a float formated text was found before. The above flags should be true or else this flag wont be true.

            int startIndex = 0; // For error checkList marking
            int endIndex = 0; // For error checkList marking

            for (int i = 0; i < inputChars.Length; i++)
            {
                isCharNotANumber = false;

                if (errorChecklist[i] == false) // This condidtion prevents IDs to be counted as numbers. 
                {
                    //
                    // PART 1: Search for a number that is being continious:
                    for (int j = 0; j < numbersDictionary.Length; j++)
                    {
                        if (inputChars[i] == numbersDictionary[j])
                        {
                            if (isPeriodFound == false) // The number is before Period. (Part1)
                            {
                                if (isNumberStartFound == false)
                                {
                                    startIndex = i; // The index of the first number is being saved for the errorChecklist
                                }
                                isNumberStartFound = true; // Start point of a number is found &/or is being continued.                                
                                break;
                            }
                            else // The number is after Period. (Part2)
                            {
                                //PART3: Find a number after the period:
                                isSecondNumberFound = true;
                                break;
                            }
                        }
                        else
                        {

                            if (j == numbersDictionary.Length - 1) // Search is failed & the character was not a number:
                            {
                                isCharNotANumber = true;
                            }
                        }
                    }
                    //                   

                    if (isCharNotANumber) // Search is failed & the character was not a number:     
                    {
                        if (isSecondNumberFound == false) // We may have met a period or there's no numbers at all.
                        {
                            if (isNumberStartFound && inputChars[i] == '.' && isPeriodFound == false)
                            {
                                isPeriodFound = true;
                            }
                            else
                            {
                                // It was not a number, Reset Everything:
                                isNumberStartFound = false;
                                isCharNotANumber = false;
                                isPeriodFound = false;
                                isSecondNumberFound = false;
                                isEndOfFloatFound = false;
                                endIndex = 0;
                                startIndex = 0;
                            }

                        }
                        else // We've reached the end of the float
                        {
                            isEndOfFloatFound = true;
                            endIndex = i - 1;
                        }
                    }

                    // Exceptions:
                    if (isEndOfFloatFound == false)
                    {
                        if (inputChars.Length == i + 1) // We are at the end of the string
                        {
                            if (isSecondNumberFound)
                            {
                                isEndOfFloatFound = true;
                                endIndex = i;
                            }
                        }
                        else
                        {
                            if (errorChecklist[i + 1] == true)
                            {
                                if (isSecondNumberFound)
                                {
                                    isEndOfFloatFound = true;
                                    endIndex = i;
                                }
                            }
                        }
                    }


                    if (isEndOfFloatFound) // The end of the float is found. So count it and check the indexes in errorChecklist.
                    {
                        // Count it:
                        floatsCount++;

                        // Check the float Characters in the checkList
                        for (int j = 0; j < endIndex - startIndex + 1; j++)
                        {
                            errorChecklist[startIndex + j] = true;
                            HighlightText(startIndex + j, lineIndex, floatColor);
                        }

                        // Reset Everything
                        isNumberStartFound = false;
                        isCharNotANumber = false;
                        isPeriodFound = false;
                        isSecondNumberFound = false;
                        isEndOfFloatFound = false;
                        startIndex = 0;
                    }
                }
                else
                {
                    // Reset Everything
                    isNumberStartFound = false;
                    isCharNotANumber = false;
                    isPeriodFound = false;
                    isSecondNumberFound = false;
                    isEndOfFloatFound = false;
                    startIndex = 0;
                }
            }
            return floatsCount;
        }



        /// <summary>
        /// This function counts the int numbers in a given string. The function SHOULD be called after CountID() & CountFloat() functions to work properly.
        /// </summary>
        /// <param name="inputLine">String of code that may include float numbers.</param>
        /// <returns>The count of floar numbers.</returns>
        int CountInts(string inputLine, bool[] errorChecklist, int lineIndex)
        {
            char[] inputChars = inputLine.ToCharArray();
            char[] numbersDictionary = "0123456789".ToCharArray();
            bool isNumberStartFound = false;
            bool isEndOfIntFound = false;
            int intsCount = 0;

            for (int i = 0; i < inputChars.Length; i++)
            {
                if (errorChecklist[i] == false) // This condidtion prevents IDs & Floats to be counted as int numbers. 
                {
                    for (int j = 0; j < numbersDictionary.Length; j++)
                    {
                        if (inputChars[i] == numbersDictionary[j])
                        {
                            isNumberStartFound = true;
                            errorChecklist[i] = true;
                            HighlightText(i, lineIndex, intColor);
                            break;
                        }
                        else
                        {
                            if (j == numbersDictionary.Length - 1) // Search has failed & the char is not a number
                            {
                                if (isNumberStartFound)
                                {
                                    isEndOfIntFound = true;
                                }
                            }
                        }
                    }

                    // Exceptions:
                    if (isEndOfIntFound == false)
                    {
                        if (inputChars.Length == i + 1) // We are at the end of the string
                        {
                            if (isNumberStartFound)
                            {
                                isEndOfIntFound = true;
                            }
                        }
                        else
                        {
                            if (errorChecklist[i + 1] == true)
                            {
                                if (isNumberStartFound)
                                {
                                    isEndOfIntFound = true;
                                }
                            }
                        }
                    }

                    if (isEndOfIntFound)
                    {
                        intsCount++;
                        isEndOfIntFound = false;
                        isNumberStartFound = false;
                    }

                }
            }

            return intsCount;
        }


        /// <summary>
        /// This function scans the errorChecklist array & returns a string containing a message & the error WORD itselfe.
        /// </summary>
        /// <param name="inputLine">Line of code that is given by user.</param>
        /// <param name="errorChecklist">The checklist that contains error character.</param>
        /// <param name="lineIndex">Index of the given line.</param>
        /// <returns>A message in this format: -Error on Line *x*: Invalid phrase "******" is found.</returns>
        string ReportErrors(string inputLine, bool[] errorChecklist, int lineIndex)
        {
            char[] inputChars = inputLine.ToCharArray();
            textBox_Errors.Text = ""; // We are using this hidden textbox as an array that it's length can be variable. Something like a list in Python we may say.

            #region Calculations:
            for (int i = 0; i < errorChecklist.Length; i++) // This part finds the start & end of a error word & counts it as one error instead of many single characters.
            {
                if (errorChecklist[i] == false)
                {
                    int startIndex = i;
                    int endIndex = startIndex;

                    for (int j = i; j < errorChecklist.Length; j++)
                    {
                        if (errorChecklist[i] == false) // Error word is still continiuning
                        {
                            endIndex = i;
                            HighlightText(i, lineIndex, errorsColor);
                            i++;
                        }
                        else // The error word is done, wrap it up as a word in the hidden textbox:
                        {
                            for (int k = 0; k < endIndex - startIndex + 1; k++)
                            {
                                textBox_Errors.Text += inputLine[startIndex + k];
                            }
                            textBox_Errors.Text += "\r\n";
                            break;
                        }
                        if (i == errorChecklist.Length) // Exception Case: The last index is also an error (This is a lazy way of fixing unfortunatly)
                        {
                            for (int k = 0; k < endIndex - startIndex + 1; k++)
                            {
                                textBox_Errors.Text += inputLine[startIndex + k];
                            }
                            textBox_Errors.Text += "\r\n";
                            break;
                        }
                    }
                }
            }
            #endregion Calculations:

            // Create the messages:
            string errorReport = "";
            for (int i = 0; i < textBox_Errors.Lines.Length - 1; i++)
            {
                errorReport += "-Error on Line " + (lineIndex + 1).ToString() + ": Invalid phrase \"" + textBox_Errors.Lines[i] + "\" is found.";
                errorReport += "\r\n";
            }
            //

            return errorReport;
        }

        #endregion Algorithm Codes

        #region UI Codes

        /// <summary>
        /// Writes the given text in the output textbox. I've made this function to make stuff easier & less fuzzy.
        /// </summary>
        /// <param name="text">String you want to write in the output.</param>
        void Print(string text)
        {
            if (checkBox_History.Checked)
            {
                textBox_Output.Text += "\r\n-----------------\r\n\r\n" + ">> " + text;
            }
            else
            {
                textBox_Output.Text = ">> " + text;
            }

            textBox_Output.SelectionStart = textBox_Output.Text.Length;
            textBox_Output.SelectionLength = 0;
            textBox_Output.ScrollToCaret();
        }

        /// <summary>
        /// Declares if the output should be cleared each time for a new output on not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_History_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_RealTime.Checked)
            {
                AnalyzeCode();
            }
        }

        /// <summary>
        /// Set all the startup requrements. Like syncing settings for example.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            AnalyzeCode();
            textBox_Input.Focus();
            numericUpDown_FontSize_ValueChanged(null, null);
            checkBox_RealTime_CheckedChanged(null, null);
        }

        /// <summary>
        /// This one is pretty much self explanetory!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Analyze_Click(object sender, EventArgs e)
        {
            AnalyzeCode();
        }

        /// <summary>
        /// If the realtime checkbox is checked, this function will update output in realTime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Input_TextChanged(object sender, EventArgs e)
        {
            if (checkBox_RealTime.Checked)
            {
                if (textBox_Input.Text != "")
                {
                    AnalyzeCode();
                }
                else
                {
                    Print("");
                    richTextBox_Input.Text = "";
                }
            }
        }

        /// <summary>
        /// Clears all Texboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ClearOutput_Click(object sender, EventArgs e)
        {
            textBox_Input.Text = "";
            textBox_Output.Text = "";
        }

        /// <summary>
        /// This button allows you to load a code from your computer in the app.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Load_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.DefaultExt = "*.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(ofd.FileName);
                    textBox_Input.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void numericUpDown_FontSize_ValueChanged(object sender, EventArgs e)
        {
            float newSize = (float)(numericUpDown_FontSize.Value);
            textBox_Input.Font = new Font(textBox_Input.Font.FontFamily, newSize);
            //textBox_Output.Font = new Font(textBox_Output.Font.FontFamily, newSize);
            richTextBox_Input.Font = new Font(textBox_Output.Font.FontFamily, newSize);            
            AnalyzeCode();
        }

        private void numericUpDown_OutputSize_ValueChanged(object sender, EventArgs e)
        {
            float newSize = (float)(numericUpDown_OutputSize.Value);
            textBox_Output.Font = new Font(textBox_Output.Font.FontFamily, newSize);
        }

        /// <summary>
        /// clips the textboxes to the edges of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            textBox_Input.Height = Height - textBox_Input.Top - 50;
            textBox_Output.Height = Height - textBox_Output.Top - 50;
            textBox_Output.Width = Width - textBox_Output.Left - 30;
            richTextBox_Input.Width = Width - richTextBox_Input.Left - 30;
        }


        // Determined Colors for the Syntax Highliting:
        Color blankColor = Color.FromArgb(55, 60, 80);
        Color operatorColor = Color.RosyBrown;
        Color idColor =  Color.PowderBlue;
        Color floatColor = Color.DarkTurquoise;
        Color intColor = Color.DodgerBlue;
        Color errorsColor = Color.FromArgb(255, 80, 80);
        Color errorsBackColor = Color.FromArgb(60, 0, 0);

        /// <summary>
        /// Colors the given index of the code with the given color. This function first calculates the index of the given line, & then colors it up.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="lineIndex"></param>
        /// <param name="c"></param>
        void HighlightText(int index, int lineIndex, Color c)
        {

            int charCount = 0;
            for (int i = 0; i < lineIndex; i++)
            {
                charCount += richTextBox_Input.Lines[i].Length + 1;
            }

            richTextBox_Input.Select(charCount + index, 1);

            if (c == blankColor) // If it's the blank character, color the backgroud insted.
            {
                richTextBox_Input.SelectionBackColor = c;
            }
            else
            {
                if (c == errorsColor) // If it's the an error character, color the backgroud as well.
                {
                    richTextBox_Input.SelectionColor = c;
                    richTextBox_Input.SelectionBackColor = errorsBackColor;
                }
                else // Anything other thar error & blank characters:
                {
                    richTextBox_Input.SelectionColor = c;
                }
            }

        }

        private void checkBox_RealTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_RealTime.Checked)
            {
                button_Analyze.Enabled = false;
            }
            else
            {
                button_Analyze.Enabled = true;
            }
        }



        #endregion UI Codes

        private void label_About_Click(object sender, EventArgs e)
        {
            toolTip_Main.Active = false;
            toolTip_Main.Active = true;
        }
    }
}

/*
 *      Lexical Analayzer V1.0
        Made by Arian Navabi

        A project for Compiler Design Class in the university.

        Islamic Azad University, West Tehran Branch,
        Started & finished on Spring 2021, while a historical pandemic was heppening!

        Contact Me:
            -ariannavabi@gmail.com
            -GitHub: github.com/ariannavabi
            -Instagram: @ArianNavabi
*/