//Schedule.cpp, n9178341
#include <iostream>
#include <string>
#include <iomanip>
#include "Schedule.h"

using namespace std;
using std::cout;
using std::endl;

//Within each allocated "Schedule" each instructor is allocated a 2d array to store bookings
char arrayJeff[7][5];
char arrayAnna[7][5];
char arrayPeter[7][5];
char arrayMichael[7][5];
char arrayKerry[7][5];

//When called this method will book a swimming lesson by storing a value of x within a certain instructors given 2d array
void Schedule::bookMethod()
{
    int day, time, instructor;
    cout <<"Enter the day you would like your lesson booked (do this using values of 1 - 5 to represent the days. eg Monday = 1, Friday = 5" << endl;
    cin >> day;
    cout <<"Enter the start time of the 1 hour lesson using numbers 1 - 8 (eg, 9am = 1, 10am = 2, 11am = 3, 12pm = 4, 1pm = 5, 2pm = 6, 3pm = 7 and 4pm = 8)" << endl;
    cin >> time;
    cout <<"Choose an instructor using numbers 1 - 5 (1 = Jeff, 2 = Anna, 3 = Peter, 4 = Michael and 5 = Kerry" << endl;
    cin >> instructor;
    switch (instructor)
    {
        case 1 :
            arrayJeff[time-1][day-1] = 'x';
            break;
        case 2 :
            arrayAnna[time-1][day-1] = 'x';
            break;
        case 3 :
            arrayPeter[time-1][day-1] = 'x';
            break;
        case 4 :
            arrayMichael[time-1][day-1] = 'x';
            break;
        case 5 :
            arrayKerry[time-1][day-1] = 'x';
            break;
    }
}

//When called this method will cancle a swimming lesson by storing a value of ' ' within a certain instructors given 2d array
void Schedule::cancelMethod()
{
    int day, time, instructor;
    cout <<"Enter the day that you booked(do this using values of 1 - 5 to represent the days. eg Monday = 1, Friday = 5" << endl;
    cin >> day;
    cout <<"Enter the start time of the 1 hour lesson using numbers 1 - 8 (eg, 9am = 1, 10am = 2, 11am = 3, 12pm = 4, 1pm = 5, 2pm = 6, 3pm = 7 and 4pm = 8)" << endl;
    cin >> time;
    cout <<"Choose an instructor using numbers 1 -5 (1 = Jeff, 2 = Anna, 3 = Peter, 4 = Michael and 5 = Kerry" << endl;
    cin >> instructor;
    switch (instructor)
    {
        case 1 :
            arrayJeff[time-1][day-1] = ' ';
            break;
        case 2 :
            arrayAnna[time-1][day-1] = ' ';
            break;
        case 3 :
            arrayPeter[time-1][day-1] = ' ';
            break;
        case 4 :
            arrayMichael[time-1][day-1] = ' ';
            break;
        case 5 :
            arrayKerry[time-1][day-1] = ' ';
            break;
    }
}

//this method takes an instructor from the user and then uses the printTable method to print out a table of when they have lessons booked
void Schedule::displayMethod()
{
    int instructor;
    cout <<"Choose an instructor using numbers 1 -5 (1 = Jeff, 2 = Anna, 3 = Peter, 4 = Michael and 5 = Kerry)" << endl;
    cin >> instructor;

    switch (instructor)
    {
        case 1 :
            printTable(arrayJeff, "Jeff");
            break;
        case 2 :
            printTable(arrayAnna, "Anna");
            break;
        case 3 :
            printTable(arrayPeter, "Peter");
            break;
        case 4 :
            printTable(arrayMichael, "Michael");
            break;
        case 5 :
            printTable(arrayKerry, "Kerry");
            break;
    }
}

//given an instructors array and name this method will print a table of when a certain instructor has swimming lessons booked and also when they are free
//this table displays x's where an instructor has a lesson booked
void Schedule::printTable(char theInstructor[7][5], char theName[7]){

    cout << "__________________________________________________________________________" << endl;
    cout << "__________________________________________________________________________" << endl;
    cout << left << theName << "   Monday   " << "Tuesday   " <<  "Wednesday    " <<  "Thursday    " <<  "Friday   " << "\n";
    cout << "__________________________________________________________________________" << endl;
    cout << "9-10\t" << theInstructor[0][0] << "\t" << theInstructor[0][1] << "\t  " << theInstructor[0][2] << "\t\t" << theInstructor[0][3] << "\t   " << theInstructor[0][4] << "\n\n";
    cout << "10-11\t" << theInstructor[1][0] << "\t" << theInstructor[1][1] << "\t  " << theInstructor[1][2] << "\t\t" << theInstructor[1][3] << "\t   " << theInstructor[1][4] << "\n\n";
    cout << "11-12\t" << theInstructor[2][0] << "\t" << theInstructor[2][1] << "\t  " << theInstructor[2][2] << "\t\t" << theInstructor[2][3] << "\t   " << theInstructor[2][4] << "\n\n";
    cout << "12-1\t" << theInstructor[3][0] << "\t" << theInstructor[3][1] << "\t  " << theInstructor[3][2] << "\t\t" << theInstructor[3][3] << "\t   " << theInstructor[3][4] << "\n\n";
    cout << "1-2\t" << theInstructor[4][0] << "\t" << theInstructor[4][1] << "\t  " << theInstructor[4][2] << "\t\t" << theInstructor[4][3] << "\t   " << theInstructor[4][4] << "\n\n";
    cout << "2-3\t" << theInstructor[5][0] << "\t" << theInstructor[5][1] << "\t  " << theInstructor[5][2] << "\t\t" << theInstructor[5][3] << "\t   " << theInstructor[5][4] << "\n\n";
    cout << "3-4\t" << theInstructor[6][0] << "\t" << theInstructor[6][1] << "\t  " << theInstructor[6][2] << "\t\t" << theInstructor[6][3] << "\t   " << theInstructor[6][4] << "\n\n";
    cout << "4-5\t" << theInstructor[7][0] << "\t" << theInstructor[7][1] << "\t  " << theInstructor[7][2] << "\t\t" << theInstructor[7][3] << "\t   " << theInstructor[7][4] << "\n\n";
    cout << "__________________________________________________________________________" << endl;
    cout << "__________________________________________________________________________" << endl;
}

//this method when called displays a table that shows every instructors avalible sessions for the week
void Schedule::availableMethod(){

    cout << "__________________________________________________________________________" << endl;
    cout << "__________________________________________________________________________" << endl;
    cout << " " << "\t" << " Monday" << "\t   " << "Tuesday" << "\t" << " Wednesday" << "\t" << " Thursday" << "\t" << " Friday" << "\n";
    cout << "__________________________________________________________________________" << endl;
    //these for loops iterate through each instructors array and creates a string of available instructors to be output
    for(int i = 0; i <= 7; i ++){
        for(int j = 0; j < 5; j++){
            string availableInstructors = " ";
            if(arrayJeff[i][j] != 'x'){
                    availableInstructors += "J/";
            }

            if(arrayAnna[i][j] != 'x'){
                    availableInstructors += "A/";
            }

            if(arrayPeter[i][j] != 'x'){
                    availableInstructors += "P/";
            }

            if(arrayMichael[i][j] != 'x'){
                    availableInstructors += "M/";
            }

            if(arrayKerry[i][j] != 'x'){
                    availableInstructors += "K/";
            }

            string availableInstructorsDisplay = availableInstructors.substr(0,availableInstructors.size()-1);
            //these if statements handle the first column output
            //each available timeslot for each instructor is printed
            // x represents when there are no available instructors for a given timeslot
            if(j == 0 && i == 0){
                if(arrayJeff[i][j] == 'x' && arrayAnna[i][j] == 'x' && arrayPeter[i][j] == 'x' && arrayMichael[i][j] == 'x' && arrayKerry[i][j] == 'x')
                {
                    cout << "9-10" << "\t" << 'x' << "\t  ";
                }
                else
                    cout << "9-10" << "\t" << availableInstructorsDisplay;
            }
            else

            if(j == 0 && i == 1){
                if(arrayJeff[i][j] == 'x' && arrayAnna[i][j] == 'x' && arrayPeter[i][j] == 'x' && arrayMichael[i][j] == 'x' && arrayKerry[i][j] == 'x')
                {
                    cout << "12-1" << "\t" << 'x' << "\t  ";
                }
                else
                    cout << "10-11" << "\t" << availableInstructorsDisplay;
            }
            else

            if(j == 0 && i == 2){
                if(arrayJeff[i][j] == 'x' && arrayAnna[i][j] == 'x' && arrayPeter[i][j] == 'x' && arrayMichael[i][j] == 'x' && arrayKerry[i][j] == 'x')
                {
                    cout << "11-12" << "\t" << 'x' << "\t  ";
                }
                else
                    cout << "11-12" << "\t" << availableInstructorsDisplay;
            }
            else

            if(j == 0 && i == 3){
                if(arrayJeff[i][j] == 'x' && arrayAnna[i][j] == 'x' && arrayPeter[i][j] == 'x' && arrayMichael[i][j] == 'x' && arrayKerry[i][j] == 'x')
                {
                    cout << "12-1" << "\t" << 'x' << "\t  ";
                }
                else
                    cout << "12-1" << "\t" << availableInstructorsDisplay;
            }
            else

            if(j == 0 && i == 4){
                if(arrayJeff[i][j] == 'x' && arrayAnna[i][j] == 'x' && arrayPeter[i][j] == 'x' && arrayMichael[i][j] == 'x' && arrayKerry[i][j] == 'x')
                {
                    cout << "1-2" << "\t" << 'x' << "\t  ";
                }
                else
                    cout << "1-2" << "\t" << availableInstructorsDisplay;
            }
            else

            if(j == 0 && i == 5){
                if(arrayJeff[i][j] == 'x' && arrayAnna[i][j] == 'x' && arrayPeter[i][j] == 'x' && arrayMichael[i][j] == 'x' && arrayKerry[i][j] == 'x')
                {
                    cout << "2-3" << "\t" << 'x' << "\t  ";
                }
                else
                    cout << "2-3" << "\t" << availableInstructorsDisplay;
            }
            else

            if(j == 0 && i == 6){
                if(arrayJeff[i][j] == 'x' && arrayAnna[i][j] == 'x' && arrayPeter[i][j] == 'x' && arrayMichael[i][j] == 'x' && arrayKerry[i][j] == 'x')
                {
                    cout << "3-4" << "\t" << 'x' << "\t  ";
                }
                else
                    cout << "3-4" << "\t" << availableInstructorsDisplay;
            }
            else

            if(j == 0 && i == 7){
                if(arrayJeff[i][j] == 'x' && arrayAnna[i][j] == 'x' && arrayPeter[i][j] == 'x' && arrayMichael[i][j] == 'x' && arrayKerry[i][j] == 'x')
                {
                    cout << "4-5" << "\t" << 'x' << "\t  ";
                }
                else
                    cout << "4-5" << "\t" << availableInstructorsDisplay;
            }

            //prints the rest of the elements (Tuesday, Wednesday, Thursday, Friday)
            else
            {
                cout << availableInstructorsDisplay << "\t";
            }

        }
        cout << "\n";
    }
    cout << "__________________________________________________________________________" << endl;
    cout << "__________________________________________________________________________" << endl;
}

//this method clears  all the bookings for every instructor by setting all values within each instructors array to ' '
void Schedule::clearMethod(){
    for(int i = 0; i < 7; i ++){
        for(int j = 0; j < 5; j++){
            arrayJeff[i][j] = ' ';
            arrayAnna[i][j] = ' ';
            arrayPeter[i][j] = ' ';
            arrayMichael[i][j] = ' ';
            arrayKerry[i][j] = ' ';
        }
    }

}

