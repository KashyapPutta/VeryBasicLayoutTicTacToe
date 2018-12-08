using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2
{
    public partial class _Default : Page
    {

        int cornernumbers = 0;
        int middlenumbers = 0;
        int computerchoice = 0;

        public ArrayList storage = new ArrayList();
        public ArrayList userStorage = new ArrayList();
        public ArrayList machineStorage = new ArrayList();


        public void Button1_Click(object sender, EventArgs e)
        {
            Button1.BackColor = System.Drawing.Color.Green;
            Button1.Text = "X";

            if (ViewState["mainStorage"] == null)
            {

                userStorage.Add(1);
                storage.Add(1);
                ViewState["mainStorage"] = storage;
                ViewState["userSelectionStorage"] = userStorage;
                ViewState["machineSelectionStorage"] = machineStorage;

            }
            else
            {

                storage = (ArrayList)ViewState["mainStorage"];
                storage.Add(1);

                userStorage = (ArrayList)ViewState["userSelectionStorage"];
                userStorage.Add(1);
                machineStorage = (ArrayList)ViewState["machineSelectionStorage"];
            }

            if (storage.Count != 9 && !machineStorage.Contains(1))
            {
                Random();

                BlockingStrategy();
                WinningStrategy();
            }

            this.Button1.Enabled = false;

        }

        public void Button2_Click(object sender, EventArgs e)
        {
            Button2.BackColor = System.Drawing.Color.Green;
            Button2.Text = "X";

            if (ViewState["mainStorage"] == null)
            {
                userStorage.Add(2);
                storage.Add(2);
                ViewState["mainStorage"] = storage;
                ViewState["userSelectionStorage"] = userStorage;
                ViewState["machineSelectionStorage"] = machineStorage;
            }
            else
            {

                storage = (ArrayList)ViewState["mainStorage"];
                storage.Add(2);

                userStorage = (ArrayList)ViewState["userSelectionStorage"];
                userStorage.Add(2);
                machineStorage = (ArrayList)ViewState["machineSelectionStorage"];
            }

            if (storage.Count != 9 && !machineStorage.Contains(2))
            {
                Random();

                BlockingStrategy();
                WinningStrategy();
            }


            this.Button2.Enabled = false;
        }

        public void Button3_Click(object sender, EventArgs e)
        {
            Button3.BackColor = System.Drawing.Color.Green;
            Button3.Text = "X";

            if (ViewState["mainStorage"] == null)
            {
                userStorage.Add(3);
                storage.Add(3);
                ViewState["mainStorage"] = storage;
                ViewState["userSelectionStorage"] = userStorage;
                ViewState["machineSelectionStorage"] = machineStorage;

            }
            else
            {

                storage = (ArrayList)ViewState["mainStorage"];
                storage.Add(3);
                userStorage = (ArrayList)ViewState["userSelectionStorage"];
                userStorage.Add(3);
                machineStorage = (ArrayList)ViewState["machineSelectionStorage"];
            }

            if (storage.Count != 9 && !machineStorage.Contains(3))
            {
                Random();

                BlockingStrategy();
                WinningStrategy();
            }


            this.Button3.Enabled = false;
        }

        public void Button4_Click(object sender, EventArgs e)
        {
            Button4.BackColor = System.Drawing.Color.Green;
            Button4.Text = "X";

            if (ViewState["mainStorage"] == null)
            {
                userStorage.Add(4);
                storage.Add(4);
                ViewState["mainStorage"] = storage;
                ViewState["userSelectionStorage"] = userStorage;
                ViewState["machineSelectionStorage"] = machineStorage;
            }
            else
            {
                storage = (ArrayList)ViewState["mainStorage"];
                storage.Add(4);

                userStorage = (ArrayList)ViewState["userSelectionStorage"];
                userStorage.Add(4);
                machineStorage = (ArrayList)ViewState["machineSelectionStorage"];
            }

            if (storage.Count != 9 && !machineStorage.Contains(4))
            {
                Random();

                BlockingStrategy();
                WinningStrategy();
            }


            this.Button4.Enabled = false;
        }

        public void Button5_Click(object sender, EventArgs e)
        {
            Button5.BackColor = System.Drawing.Color.Green;
            Button5.Text = "X";

            if (ViewState["mainStorage"] == null)
            {
                userStorage.Add(5);
                storage.Add(5);
                ViewState["mainStorage"] = storage;
                ViewState["userSelectionStorage"] = userStorage;
                ViewState["machineSelectionStorage"] = machineStorage;
            }
            else
            {
                storage = (ArrayList)ViewState["mainStorage"];
                storage.Add(5);

                userStorage = (ArrayList)ViewState["userSelectionStorage"];
                userStorage.Add(5);
                machineStorage = (ArrayList)ViewState["machineSelectionStorage"];
            }

            if (storage.Count != 9 && !machineStorage.Contains(5))
            {
                Random();

                BlockingStrategy();
                WinningStrategy();
            }


            this.Button5.Enabled = false;
        }

        public void Button6_Click(object sender, EventArgs e)
        {
            Button6.BackColor = System.Drawing.Color.Green;
            Button6.Text = "X";

            if (ViewState["mainStorage"] == null)
            {
                userStorage.Add(6);
                storage.Add(6);
                ViewState["mainStorage"] = storage;
                ViewState["userSelectionStorage"] = userStorage;
                ViewState["machineSelectionStorage"] = machineStorage;
            }
            else
            {
                storage = (ArrayList)ViewState["mainStorage"];
                storage.Add(6);

                userStorage = (ArrayList)ViewState["userSelectionStorage"];
                userStorage.Add(6);

                machineStorage = (ArrayList)ViewState["machineSelectionStorage"];
            }

            if (storage.Count != 9 && !machineStorage.Contains(6))
            {
                Random();

                BlockingStrategy();
                WinningStrategy();
            }


            this.Button6.Enabled = false;
        }

        public void Button7_Click(object sender, EventArgs e)
        {
            Button7.BackColor = System.Drawing.Color.Green;
            Button7.Text = "X";

            if (ViewState["mainStorage"] == null)
            {
                userStorage.Add(7);
                storage.Add(7);
                ViewState["mainStorage"] = storage;
                ViewState["userSelectionStorage"] = userStorage;
                ViewState["machineSelectionStorage"] = machineStorage;
            }
            else
            {
                storage = (ArrayList)ViewState["mainStorage"];
                storage.Add(7);

                userStorage = (ArrayList)ViewState["userSelectionStorage"];
                userStorage.Add(7);
                machineStorage = (ArrayList)ViewState["machineSelectionStorage"];
            }

            if (storage.Count != 9 && !machineStorage.Contains(7))
            {
                Random();

                BlockingStrategy();
                WinningStrategy();
            }


            this.Button7.Enabled = false;
        }

        public void Button8_Click(object sender, EventArgs e)
        {
            Button8.BackColor = System.Drawing.Color.Green;
            Button8.Text = "X";

            if (ViewState["mainStorage"] == null)
            {
                userStorage.Add(8);
                storage.Add(8);
                ViewState["mainStorage"] = storage;
                ViewState["userSelectionStorage"] = userStorage;
                ViewState["machineSelectionStorage"] = machineStorage;
            }
            else
            {
                storage = (ArrayList)ViewState["mainStorage"];
                storage.Add(8);

                userStorage = (ArrayList)ViewState["userSelectionStorage"];
                userStorage.Add(8);
                machineStorage = (ArrayList)ViewState["machineSelectionStorage"];
            }

            if (storage.Count != 9 && !machineStorage.Contains(8))
            {
                Random();

                BlockingStrategy();
                WinningStrategy();
            }


            this.Button8.Enabled = false;
        }

        public void Button9_Click(object sender, EventArgs e)
        {
            Button9.BackColor = System.Drawing.Color.Green;
            Button9.Text = "X";

            if (ViewState["mainStorage"] == null)
            {
                userStorage.Add(9);
                storage.Add(9);
                ViewState["mainStorage"] = storage;
                ViewState["userSelectionStorage"] = userStorage;
                ViewState["machineSelectionStorage"] = machineStorage;
            }
            else
            {
                storage = (ArrayList)ViewState["mainStorage"];
                storage.Add(9);

                userStorage = (ArrayList)ViewState["userSelectionStorage"];
                userStorage.Add(9);
                machineStorage = (ArrayList)ViewState["machineSelectionStorage"];
            }

            if (storage.Count != 9 && !machineStorage.Contains(9))
            {
                Random();

                BlockingStrategy();
                WinningStrategy();
            }

            this.Button9.Enabled = false;
        }


        public void Random()
        {


            if (!storage.Contains(1) || !storage.Contains(3) || !storage.Contains(7) || !storage.Contains(9))
            {

                bool corner = true;
                while (corner)
                {
                    Random rnd = new Random();
                    cornernumbers = rnd.Next(1, 10);


                    if (cornernumbers == 1 || cornernumbers == 3 || cornernumbers == 7 || cornernumbers == 9)
                    {

                        if (storage.Contains(cornernumbers))
                        {
                            corner = true;
                        }

                        else
                        {
                            corner = false;

                        }
                    }
                }
                computerchoice = cornernumbers;
            }

            if (storage.Contains(1) && storage.Contains(3) && storage.Contains(7) && storage.Contains(9))
            {
                int middlenumbers = 0;
                bool entry = true;
                while (entry)
                {
                    Random rndam = new Random();
                    middlenumbers = rndam.Next(1, 9);

                    if (middlenumbers == 2 || middlenumbers == 4 || middlenumbers == 6 || middlenumbers == 8)
                    {
                        if (storage.Contains(middlenumbers))
                        {
                            entry = true;
                        }
                        else
                            entry = false;

                    }

                }
                computerchoice = middlenumbers;
            }

            if (!userStorage.Contains(5) && !machineStorage.Contains(5))
            {
                computerchoice = 5;

            }


            BlockingStrategy();

            WinningStrategy();

            if (computerchoice == 1)
            {
                Button1.BackColor = System.Drawing.Color.Red;
                Button1.Text = "O";
                this.Button1.Enabled = false;
                save();
            }

            if (computerchoice == 2)
            {
                Button2.BackColor = System.Drawing.Color.Red;
                Button2.Text = "O";
                this.Button2.Enabled = false;
                save();
            }

            if (computerchoice == 3)
            {
                Button3.BackColor = System.Drawing.Color.Red;
                Button3.Text = "O";
                this.Button3.Enabled = false;
                save();
            }

            if (computerchoice == 4)
            {
                Button4.BackColor = System.Drawing.Color.Red;
                Button4.Text = "O";
                this.Button4.Enabled = false;
                save();
            }

            if (computerchoice == 5)
            {
                Button5.BackColor = System.Drawing.Color.Red;
                Button5.Text = "O";
                this.Button5.Enabled = false;
                save();
            }

            if (computerchoice == 6)
            {
                Button6.BackColor = System.Drawing.Color.Red;
                Button6.Text = "O";
                this.Button6.Enabled = false;
                save();
            }

            if (computerchoice == 7)
            {
                Button7.BackColor = System.Drawing.Color.Red;
                Button7.Text = "O";
                this.Button7.Enabled = false;
                save();
            }

            if (computerchoice == 8)
            {
                Button8.BackColor = System.Drawing.Color.Red;
                Button8.Text = "O";
                this.Button8.Enabled = false;
                save();
            }

            if (computerchoice == 9)
            {
                Button9.BackColor = System.Drawing.Color.Red;
                Button9.Text = "O";
                this.Button9.Enabled = false;
                save();
            }

            

        }



        public void BlockingStrategy()
        {
            //*******************************START OF MACHINE BLOCKING STRATEGY*****************************************

            // bLOCKING USER 1,2----3 MACHINE
            if (userStorage.Contains(1) && userStorage.Contains(2) && !machineStorage.Contains(3))
            {
                computerchoice = 3;
            }




            // bLOCKING USER 1,3----2 MACHINE
            if (userStorage.Contains(1) && userStorage.Contains(3) && !machineStorage.Contains(2))
            {
                computerchoice = 2;
            }



            // bLOCKING USER 2,3----1 MACHINE
            if (userStorage.Contains(2) && userStorage.Contains(3) && !machineStorage.Contains(1))
            {
                computerchoice = 1;
            }



            //############################################################### HORIZONTAL 2 MACHINE BLOCK

            // bLOCKING USER 4,5----6 MACHINE
            if (userStorage.Contains(4) && userStorage.Contains(5) && !machineStorage.Contains(6))
            {
                computerchoice = 6;
            }



            // bLOCKING USER 4,6----5 MACHINE
            if (userStorage.Contains(4) && userStorage.Contains(6) && !machineStorage.Contains(5))
            {
                computerchoice = 5;
            }



            // bLOCKING USER 5,6----4 MACHINE
            if (userStorage.Contains(5) && userStorage.Contains(6) && !machineStorage.Contains(4))
            {
                computerchoice = 4;
            }


            //############################################################### HORIZONTAL 3 MACHINE BLOCK

            // bLOCKING USER 7,8----9 MACHINE
            if (userStorage.Contains(7) && userStorage.Contains(8) && !machineStorage.Contains(9))
            {
                computerchoice = 9;
            }



            // bLOCKING USER 8,9----7 MACHINE
            if (userStorage.Contains(8) && userStorage.Contains(9) && !machineStorage.Contains(7))
            {
                computerchoice = 7;
            }



            // bLOCKING USER 7,9----8 MACHINE
            if (userStorage.Contains(7) && userStorage.Contains(9) && !machineStorage.Contains(8))
            {
                computerchoice = 8;
            }



            //############################################################################ VERTICAL MACHINE BLOCK

            // bLOCKING USER 1,4----7 MACHINE
            if (userStorage.Contains(1) && userStorage.Contains(4) && !machineStorage.Contains(7))
            {
                computerchoice = 7;
            }



            // bLOCKING USER 4,7----1 MACHINE

            if (userStorage.Contains(4) && userStorage.Contains(7) && !machineStorage.Contains(1))
            {
                computerchoice = 1;
            }



            // bLOCKING USER 1,7----4 MACHINE
            if (userStorage.Contains(1) && userStorage.Contains(7) && !machineStorage.Contains(4))
            {
                computerchoice = 4;
            }



            //############################################################################ VERTICAL 2 MACHINE BLOCK


            // bLOCKING USER 2,5----8 MACHINE
            if (userStorage.Contains(2) && userStorage.Contains(5) && !machineStorage.Contains(8))
            {
                computerchoice = 8;
            }



            // bLOCKING USER 5,8----2 MACHINE
            if (userStorage.Contains(5) && userStorage.Contains(8) && !machineStorage.Contains(2))
            {
                computerchoice = 2;
            }



            // bLOCKING USER 2,8----5 MACHINE
            if (userStorage.Contains(2) && userStorage.Contains(8) && !machineStorage.Contains(5))
            {
                computerchoice = 5;
            }



            //############################################################################ VERTICAL 3 MACHINE BLOCK

            // bLOCKING USER 3,6----9 MACHINE
            if (userStorage.Contains(3) && userStorage.Contains(6) && !machineStorage.Contains(9))
            {
                computerchoice = 9;
            }



            // bLOCKING USER 6,9----3 MACHINE
            if (userStorage.Contains(6) && userStorage.Contains(9) && !machineStorage.Contains(3))
            {
                computerchoice = 3;
            }



            // bLOCKING USER 3,9----6 MACHINE
            if (userStorage.Contains(3) && userStorage.Contains(9) && !machineStorage.Contains(6))
            {
                computerchoice = 6;
            }


            //############################################################################ DIAGNOL 1 MACHINE BLOCK


            // bLOCKING USER 1,5----9 MACHINE
            if (userStorage.Contains(1) && userStorage.Contains(5) && !machineStorage.Contains(9))
            {
                computerchoice = 9;
            }



            // bLOCKING USER 1,9----5 MACHINE
            if (userStorage.Contains(1) && userStorage.Contains(9) && !machineStorage.Contains(5))
            {
                computerchoice = 5;
            }



            // bLOCKING USER 5,9----1 MACHINE
            if (userStorage.Contains(5) && userStorage.Contains(9) && !machineStorage.Contains(1))
            {
                computerchoice = 1;
            }



            //############################################################################ DIAGNOL 2 MACHINE BLOCK

            // bLOCKING USER 3,5----7 MACHINE
            if (userStorage.Contains(3) && userStorage.Contains(5) && !machineStorage.Contains(7))
            {
                computerchoice = 7;
            }



            // bLOCKING USER 5,7----3 MACHINE
            if (userStorage.Contains(5) && userStorage.Contains(7) && !machineStorage.Contains(3))
            {
                computerchoice = 3;
            }


            // bLOCKING USER 3,7----5 MACHINE
            if (userStorage.Contains(3) && userStorage.Contains(7) && !machineStorage.Contains(5))
            {
                computerchoice = 5;
            }

            //********************************END OF MACHINE BLOCKING STRATEGY*****************************************
            //********************************END OF MACHINE BLOCKING STRATEGY*****************************************

        }



        public void WinningStrategy()
        {
            //*******************************START OF MACHINE WINNING STRATEGY*****************************************



            // Machine Winning ---- 1,2,3

            if (machineStorage.Contains(1) && machineStorage.Contains(2) && !machineStorage.Contains(3) && !userStorage.Contains(3))
            {
                computerchoice = 3;
            }

            if (machineStorage.Contains(1) && machineStorage.Contains(3) && !machineStorage.Contains(2) && !userStorage.Contains(2))
            {
                computerchoice = 2;
            }

            if (machineStorage.Contains(2) && machineStorage.Contains(3) && !machineStorage.Contains(1) && !userStorage.Contains(1))
            {
                computerchoice = 1;
            }

            // Machine Winning ---- 4,5,6
            if (machineStorage.Contains(4) && machineStorage.Contains(5) && !machineStorage.Contains(6) && !userStorage.Contains(6))
            {
                computerchoice = 6;
            }

            if (machineStorage.Contains(4) && machineStorage.Contains(6) && !machineStorage.Contains(5) && !userStorage.Contains(5))
            {
                computerchoice = 5;
            }

            if (machineStorage.Contains(5) && machineStorage.Contains(6) && !machineStorage.Contains(4) && !userStorage.Contains(4))
            {
                computerchoice = 4;
            }

            // Machine Winning ---- 7,8,9

            if (machineStorage.Contains(7) && machineStorage.Contains(8) && !machineStorage.Contains(9) && !userStorage.Contains(9))
            {
                computerchoice = 9;
            }

            if (machineStorage.Contains(8) && machineStorage.Contains(9) && !machineStorage.Contains(7) && !userStorage.Contains(7))
            {
                computerchoice = 7;
            }

            if (machineStorage.Contains(7) && machineStorage.Contains(9) && !machineStorage.Contains(8) && !userStorage.Contains(8))
            {
                computerchoice = 8;
            }

            // Machine Winning ---- 1,4,7

            if (machineStorage.Contains(1) && machineStorage.Contains(4) && !machineStorage.Contains(7) && !userStorage.Contains(7))
            {
                computerchoice = 7;
            }

            if (machineStorage.Contains(4) && machineStorage.Contains(7) && !machineStorage.Contains(1) && !userStorage.Contains(1))
            {
                computerchoice = 1;
            }

            if (machineStorage.Contains(1) && machineStorage.Contains(7) && !machineStorage.Contains(4) && !userStorage.Contains(4))
            {
                computerchoice = 4;
            }

            // Machine Winning ---- 2,5,8

            if (machineStorage.Contains(2) && machineStorage.Contains(5) && !machineStorage.Contains(8) && !userStorage.Contains(8))
            {
                computerchoice = 8;
            }

            if (machineStorage.Contains(5) && machineStorage.Contains(8) && !machineStorage.Contains(2) && !userStorage.Contains(2))
            {
                computerchoice = 2;
            }

            if (machineStorage.Contains(2) && machineStorage.Contains(8) && !machineStorage.Contains(5) && !userStorage.Contains(5))
            {
                computerchoice = 5;
            }

            // Machine Winning ---- 3,6,9

            if (machineStorage.Contains(3) && machineStorage.Contains(6) && !machineStorage.Contains(9) && !userStorage.Contains(9))
            {
                computerchoice = 9;
            }

            if (machineStorage.Contains(6) && machineStorage.Contains(9) && !machineStorage.Contains(3) && !userStorage.Contains(3))
            {
                computerchoice = 3;
            }

            if (machineStorage.Contains(3) && machineStorage.Contains(9) && !machineStorage.Contains(6) && !userStorage.Contains(6))
            {
                computerchoice = 6;
            }

            // Machine Winning ---- 1,5,9

            if (machineStorage.Contains(1) && machineStorage.Contains(5) && !machineStorage.Contains(9) && !userStorage.Contains(9))
            {
                computerchoice = 9;
            }

            if (machineStorage.Contains(1) && machineStorage.Contains(9) && !machineStorage.Contains(5) && !userStorage.Contains(5))
            {
                computerchoice = 5;
            }

            if (machineStorage.Contains(5) && machineStorage.Contains(9) && !machineStorage.Contains(1) && !userStorage.Contains(1))
            {
                computerchoice = 1;
            }

            // Machine Winning ---- 3,5,7

            if (machineStorage.Contains(3) && machineStorage.Contains(5) && !machineStorage.Contains(7) && !userStorage.Contains(7))

            {
                computerchoice = 7;
            }

            if (machineStorage.Contains(5) && machineStorage.Contains(7) && !machineStorage.Contains(3) && !userStorage.Contains(3))
            {
                computerchoice = 3;
            }

            if (machineStorage.Contains(3) && machineStorage.Contains(7) && !machineStorage.Contains(5) && !userStorage.Contains(5))
            {
                computerchoice = 5;
            }

            // ********************************END of WINNING STRATEGY******************************************
        }


        public void save()
        {
            storage.Add(computerchoice);
            ViewState["mainStorage"] = storage;
            machineStorage.Add(computerchoice);
            ViewState["machineSelectionStorage"] = machineStorage;
        }

    }


}




