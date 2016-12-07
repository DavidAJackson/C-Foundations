using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct ItemData
{
    public int itemIDNo;
    public string sDescription;
    public double dblPricePerItem;
    public int iQuantityOnHand;
    public double dblOurCostPerItem;
    public double dblValueOfItem;
}



class MyInventory
{
    public static void Main()
    {
        // use an interger to keep track of the count of items in your inventory					
        int icount = 0;

        // create an array of your ItemData struct
        var itemprop = new ItemData[200];
        // use a never ending loop that shows the user what options they can select 
        int optx = 1;
        while (optx != 0)
        {
            Console.Write("Slect an action using a number: \n1. Add an item \n2. Change an Item (by giving its item number) \n3. Delete an item (by giving its item number) \n4. List all items in the database \n5. Quit\n");


            string strx = Console.ReadLine();   // read user's input	

            optx = int.Parse(strx); // convert the given string to integer to match our case types shown below

            Console.WriteLine(); // provide an extra blank line on screen

            switch (optx)
            {
                case 1: // add an item to the list if this option is selected
                    //asking for each item
                    Console.Write("Item ID:");
                    int itemID = int.Parse(Console.ReadLine());
                    Console.Write("Item Description:");
                    string description = Console.ReadLine();
                    Console.Write("Item Price per Item:");
                    double priceper = int.Parse(Console.ReadLine());
                    Console.Write("Items on Hand:");
                    int itemOnhand = int.Parse(Console.ReadLine());
                    Console.Write("Item 'at cost':");
                    double itemcost = int.Parse(Console.ReadLine());
                    
                    //storing each item
                    itemprop[icount].itemIDNo = itemID;
                    itemprop[icount].sDescription = description;
                    itemprop[icount].dblPricePerItem = priceper;
                    itemprop[icount].iQuantityOnHand = itemOnhand;
                    itemprop[icount].dblOurCostPerItem = itemcost;
                    itemprop[icount].dblValueOfItem = priceper*itemOnhand;
                    //updating the count of items
                    icount++;

                    break;


                case 2: //change items in the list if this option is selected

                    Console.Write("Please enter an item No:");
                    string strchgid = Console.ReadLine();
                    int chgid = int.Parse(strchgid);
                    bool fFound = false;
                    
                    for (int x = 0; x < icount; x++)
                    {
                        if (x == chgid)
                        {
                            fFound = true;
                            //asking for each item
                            Console.Write("Item ID:");
                            int sitemID = int.Parse(Console.ReadLine());
                            Console.Write("Item Description:");
                            string sdescription = Console.ReadLine();
                            Console.Write("Item Price per Item:");
                            double spriceper = int.Parse(Console.ReadLine());
                            Console.Write("Items on Hand:");
                            int sitemOnhand = int.Parse(Console.ReadLine());
                            Console.Write("Item 'at cost':");
                            double sitemcost = int.Parse(Console.ReadLine());
                            
                            // storing each item
                            itemprop[chgid].itemIDNo = sitemID;
                            itemprop[chgid].sDescription = sdescription;
                            itemprop[chgid].dblPricePerItem = spriceper;
                            itemprop[chgid].iQuantityOnHand = sitemOnhand;
                            itemprop[chgid].dblOurCostPerItem = sitemcost;
                            itemprop[chgid].dblValueOfItem = spriceper*sitemOnhand;

                            
                            
                       }
                    }

                    if (!fFound) // and if not found
                    {
                        Console.WriteLine("Item {0} not found", chgid);
                    }

                    break;


                case 3: //delete items in the list if this option is selected

                    Console.Write("Please enter an item No:");
                    string strnewid = Console.ReadLine();
                    int newid =  int.Parse(strnewid);
                    bool fDeleted = false;



                    // declare and define a new array one element shorter than the old array
                    var newitemprop = new ItemData[icount];

                        // loop from 0 to the length of the new array, with i being the position
                        // in the new array, and j being the position in the old array
                        for (int i = 0, j = 0; i < newitemprop.Length; i++, j++)
                        {
                            // if the index equals the one we want to remove, bump
                            // j up by one to "skip" the value in the original array
                            if (i == newid)
                            {
                                fDeleted = true;
                                j++;
                            }
                            

                            // assign the good element from the original array to the
                            // new array at the appropriate position
                            newitemprop[i] = itemprop[j];
                        }

                        // overwrite the old array with the new one
                        itemprop = newitemprop;

                    if (fDeleted) // hint the user that you deleted the requested item
                    {
                        Console.WriteLine("Item deleted");
                    }
                    else // if did not find it, hint the user that you did not find it in your list
                    {
                        Console.WriteLine("Item {0} not found", newid);
                    }

                    break;




                   


                case 4:  //list all items in current database if this option is selected

                    //Console.Write("")
                    //int iquan = int.Parse(strquan);
                    Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                    Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");
                    for (int x = 0; x < icount; x++)
                    {
                        
                            Console.Write("{0,5}  ", x);
                            Console.Write("{0,6}  ", itemprop[x].itemIDNo);
                            Console.Write("{0,-20}  ", itemprop[x].sDescription);
                            Console.Write("{0,5}  ", itemprop[x].dblPricePerItem);
                            Console.Write("{0,3}  ", itemprop[x].iQuantityOnHand);
                            Console.Write("{0,4}  ", itemprop[x].dblOurCostPerItem);
                            Console.Write("{0,5}  \n", itemprop[x].dblValueOfItem);
                            
                     
                    }
                    Console.ReadLine();

                    break;



                case 5: //quit the program if this option is selected

                    Console.Write("Are you sure that you want to quit(y/n)?\n");
                    string strresp = Console.ReadLine();

                    if (strresp == "y")
                    {
                        optx = 0;	//as long as it is not 5, the process is not breaking	
                    }
                    break;


                default:

                    Console.Write("Invalid Option, try again");
                    break;

            }
        }
    }
}

