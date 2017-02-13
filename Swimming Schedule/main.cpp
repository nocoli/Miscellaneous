//main.cpp n9178341
#include <iostream>
#include <string>
#include <iomanip>
#include "Schedule.h"
using namespace std;
using std::cout;
using std::endl;

//Function prototypes

void mainMenu();

//global variables
Schedule theSchedule;

//main function
int main()
{
    for(;;){
    mainMenu();
    }
}

//function to display the main menu and hanlde the users needs
void mainMenu()
{
    int x;
    cout << "_________________________________MAIN_MENU__________________________________" << endl;
    cout << " - Press '1' To book a swimming lesson for a club member" << endl;
    cout << " - Press '2' To cancel a swimming lesson" << endl;
    cout << " - Press '3' To display the current schedule of a swimming instructor" << endl;
    cout << " - Press '4' To display all of the time slots that are avalible for booking" << endl;
    cout << " - Press '5' To clear all of the schedules" << endl;
    cout << "____________________________________________________________________________" <<endl;
    cin >> x;
    switch(x)
    {
        case 1 :theSchedule.bookMethod();
            break;
        case 2 :theSchedule.cancelMethod();
            break;
        case 3 :theSchedule.displayMethod();
            break;
        case 4 :theSchedule.availableMethod();
            break;
        case 5 :theSchedule.clearMethod();
            break;
    }
}
