

static void AddNewClient()
{
    sClient client = ReadNewClient();

    AddDataLineToFile(
        ClientsFileName,
        ConvertRecordToLine(client)
    );
}

static void AddNewClients()
{
    char AddMore = 'y';
    do
    {
        Conosle.WriteLine("adding New Client :");
        AddNewClient();
        Conosle.WriteLine("client added successfully,do you want to add more clients? Y/N? ");
        AddMore = Console.ReadLine();


    }
}

ShowAddNewClientsScreen(){
    Conosle.WriteLine("===============================================");
    Conosle.WriteLine("Add New Clients Screen : ");
    Conosle.WriteLine("===============================================");
    AddNewClients();

}

static void ShowAllClientsScreen()
{
    List<sClient> clients = LoadClientsDataFromFile(clientsFileName);
    Conosle.WriteLine("\t\t\t\t\t list clint : "+clients.Count()+" clints");
    Conosle.WriteLine("===============================================");
    Console.WriteLine(
    $"| {"Account Number",-15}" +
    $"| {"Pin Code",-10}" +
    $"| {"Client Name",-40}" +
    $"| {"Phone",-12}" +
    $"| {"Balance",-12}|"
);
    Conosle.WriteLine("===============================================");
    if (clients.Count() == 0)
        Conosle.WriteLine("no avilable client in the systme");
    else
        foreach (sClient Client in clients)
        {
            printclientrecordlient(Client);
        }

    Conosle.WriteLine("===============================================");
    Conosle.WriteLine("===============================================");



}
static void GoBackToMainMenue()
{
    Conosle.WriteLine("prese any key to go back to main menue... ");
    System("pause>0");
    ShowMainManue();
}
static int ReadMainMenueOption()
{
    Conosle.WriteLine("What do you want to do ? { 1 - 6 }");
    int Choice = 0;
    Choice = Console.ReadLine();
    return Choice;
}
static void PerfromMainManueOption(enMainMenueOptions MainMenueOptions)
{
    switch (MainMenueOptions)
    {
        case elistClints:
            {
                System("cls");
                ShowAllClientsScreen();
                GoBackToMainMenue();
                break;
            }
        case eAddNewClient:
            {
                System("cls");
                ShowAddNewClientsScreen();
                GoBackToMainMenue();
                break;
            }
        case eDeleteClient:
            {
                System("cls");
                ShowDeleteClientsScreen();
                GoBackToMainMenue();
                break;
            }
        case eUpdateClient:
            {
                System("cls");
                ShowUpdateClientsScreen();
                GoBackToMainMenue();
                break;
            }
        case eFindClient:
            {
                System("cls");
                ShowFindClientsScreen();
                GoBackToMainMenue();
                break;
            }
        case eExit:
            {
                System("cls");
                ShowEndScreen();
                break;
            }


    }
}
static void ShowMainManue()
{
    System("cls");
    Conosle.WriteLine("===============================================");
    Conosle.WriteLine("main manue screen ");
    Conosle.WriteLine("===============================================");
    Conosle.WriteLine("[1] Show Client list:");
    Conosle.WriteLine("[2] Add New Client: ");
    Conosle.WriteLine("[3] Delete Client: ");
    Conosle.WriteLine("[4] Update Clinet Info: ");
    Conosle.WriteLine("[5] Fined Client:");
    Conosle.WriteLine("[6] Exit"); 
    Conosle.WriteLine("===============================================");
    PerfromMainManueOption((enMainMenueOptions)ReadMainMenueOption());
}
static void main()
{
    ShowMainManue();
    System("");
}