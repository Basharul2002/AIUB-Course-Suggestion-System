#include<bits/stdc++.h>
#include <sstream>
#include <exception>

// Define macros for different platforms
#ifdef _WIN32
    #define WINDOWS_OS
#endif

// Function prototypes
void setTextColorRed();
void setTextColorGreen();
void setTextColorCyan();
void setTextColorYellow();
void resetTextColor();

#ifdef WINDOWS_OS
    #include <windows.h> // For Windows Console API

    void setTextColorRed()
    {
        HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
        SetConsoleTextAttribute(hConsole, FOREGROUND_RED | FOREGROUND_INTENSITY);
    }


    void setTextColorGreen()
    {
        HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
        SetConsoleTextAttribute(hConsole, FOREGROUND_GREEN | FOREGROUND_INTENSITY);
    }


    void setTextColorCyan()
    {
        HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
        SetConsoleTextAttribute(hConsole, FOREGROUND_GREEN | FOREGROUND_BLUE | FOREGROUND_INTENSITY);
    }

    void setTextColorYellow()
    {

        HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
        SetConsoleTextAttribute(hConsole, FOREGROUND_RED | FOREGROUND_GREEN | FOREGROUND_INTENSITY);
    }

    void resetTextColor()
    {

        HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
        SetConsoleTextAttribute(hConsole, FOREGROUND_RED | FOREGROUND_GREEN | FOREGROUND_BLUE);
    }


#else
    // Define dummy functions for non-Windows platforms
    void setTextColorRed();
    void setTextColorGreen();
    void setTextColorCyan();
    void setTextColorYellow();
    void resetTextColor();
#endif



using namespace std;

bool outOfRange = false;

// Define a structure to hold course information
struct Course
{
    string name;
    unordered_set<int> prerequisites;
    int courseCredit;
};


// Function Prototypes
void departmentOption(bool initial = true);
void repeatExecution(string department, bool invalid = false);
void departmentChoose(string dept);
vector<int> parseInput(const string& input, const string& dept);
void cseCourses();
void eeeCourses();
void courseDataUserInput(vector<Course>allCourses, string dept, bool error = false);
void printCourses(const vector<Course>& courses);
void recommendCourses(const vector<Course>& allCourses, const vector<int>& completedCourses, int totalCreditCompleted);


int main()
{
    departmentOption();
    cin.ignore(); // To consume the newline character left by previous input
    return 0;
}


// Function to prompt the user to choose a department
void departmentOption(bool initial)
{
    if(initial)
    {
        //setTextColorCyan();
        cout << "Department name: ";

        //resetTextColor();
        cout << "\n1.CSE \n2.EEE \n\nChoose Your Department: ";
    }


    else
    {
        setTextColorRed();
        cout << "\nInvalid Department Choice!\n";

        resetTextColor();
        cout << "Please enter a valid option: ";
    }


    string department;
    setTextColorGreen();
    cin>>department;
    cin.ignore();   // To handle any remaining newline character
    resetTextColor();
    departmentChoose(department);
}


// Function to handle the department choice
void departmentChoose(string department)
{
    // Convert the input to uppercase for uniform comparison
    transform(department.begin(), department.end(), department.begin(), ::toupper);

    if(department == "1" || department == "CSE")
    {
        cseCourses(); // Call the function to handle CSE courses
        repeatExecution("1"); // Prompt to repeat execution after handling CSE courses
    }

    else if(department == "2" || department == "EEE")
    {
        eeeCourses(); // Call the function to handle EEE courses
        repeatExecution("2"); // Prompt to repeat execution after handling EEE courses
    }

    else
        departmentOption(false); // Re-prompt for department choice if input is invalid

}


// Function to handle the repetition of the program based on user's choice
void repeatExecution(string department, bool invalid)
{
    if(!invalid)
    {
        setTextColorYellow();
        cout << "\n\nWould you like to run the program again?\n";

        resetTextColor();
        cout << "1: Yes\n";
        cout << "2: Exit\n";
        cout << "3: Go back to the department selection\n";
        cout << "\nPlease enter your choice (1, 2, or 3): ";
    }

    setTextColorGreen();
    string input;
    cin>>input;

    resetTextColor();

    // Convert the input to lowercase for uniform comparison
    transform(department.begin(), department.end(), department.begin(), ::tolower);

    if(input == "1" || input == "yes")
    {
        cin.ignore();
        departmentChoose(department); // Repeat the current department's course handling
    }

    else if(input == "2" || input == "exit")
    {
        cin.ignore();
        exit(0);  // Exit the program
    }

    else if(input == "3")
    {
        cout<<"\n\n";
        departmentOption(); // Go back to the department selection
    }

    else
    {
        setTextColorRed();
        cout << "\nInvalid choice! \n";

        resetTextColor();
        cout << "Please enter 1, 2 or 3: ";
        repeatExecution(department, true); // Re-prompt for valid input
    }

}


// Function to handle CSE courses (dummy implementation for illustration)
void cseCourses()
{
    vector<Course> allCourses =
    {
        // semester 1
        {"DIFFERENTIAL CALCULUS & CO-ORDINATE GEOMETRY", {}, 3},
        {"PHYSICS 1", {}, 3},
        {"PHYSICS 1 LAB", {1}, 1},
        {"ENGLISH READING SKILLS & PUBLIC SPEAKING", {}, 3},
        {"INTRODUCTION TO PROGRAMMING", {}, 3},
        {"INTRODUCTION TO PROGRAMMING LAB", {5}, 1},
        {"INTRODUCTION TO COMPUTER STUDIES", {}, 1},

        // semester 2
        {"DISCRETE MATHEMATICS", {1, 5}, 3},
        {"INTEGRAL CALCULUS & ORDINARY DIFFERENTIAL EQUATIONS", {1}, 3},
        {"OBJECT ORIENTED PROGRAMMING 1", {5, 6}, 3},
        {"PHYSICS 2", {2}, 3},
        {"PHYSICS 2 LAB", {3}, 1},
        {"ENGLISH WRITING SKILLS & COMMUNICATION", {4}, 3},
        {"INTRODUCTION TO ELECTRICAL CIRCUITS", {2}, 3},
        {"INTRODUCTION TO ELECTRICAL CIRCUITS LAB", {3}, 1},

        // semester 3
        {"CHEMISTRY", {11}, 3},
        {"COMPLEX VARIABLE, LAPLACE & Z-TRANSFORMATION", {9}, 3},
        {"INTRODUCTION TO DATABASE", {10}, 3},
        {"ELECTRONIC DEVICES", {14}, 3},
        {"ELECTRONIC DEVICES LAB", {15}, 1},
        {"PRINCIPLES OF ACCOUNTING", {9}, 3},
        {"DATA STRUCTURE", {8, 10}, 3},
        {"DATA STRUCTURE LAB", {8, 10}, 1},
        {"COMPUTER AIDED DESIGN & DRAFTING", {}, 1},
        {"ALGORITHMS", {22, 23}, 3},
        {"MATRICES, VECTORS, FOURIER ANALYSIS", {17}, 3},
        {"OBJECT ORIENTED PROGRAMMING 2", {10, 19}, 3},
        {"OBJECT ORIENTED ANALYSIS AND DESIGN", {20}, 3},
        {"BANGLADESH STUDIES", {6}, 3},
        {"DIGITAL LOGIC AND CIRCUITS", {15}, 3},
        {"DIGITAL LOGIC AND CIRCUITS LAB", {16}, 1},
        {"COMPUTATIONAL STATISTICS AND PROBABILITY", {17}, 3},
        {"THEORY OF COMPUTATION", {25}, 3},
        {"PRINCIPLES OF ECONOMICS", {31}, 2},
        {"BUSINESS COMMUNICATION", {28}, 3},
        {"NUMERICAL METHODS FOR SCIENCE AND ENGINEERING", {25}, 3},
        {"DATA COMMUNICATION", {31, 32}, 3},
        {"MICROPROCESSOR AND EMBEDDED SYSTEM", {31, 32}, 3},
        {"SOFTWARE ENGINEERING", {27, 28}, 3},
        {"ARTIFICIAL INTELLIGENCE AND EXPERT SYS.", {25, 31}, 3},
        {"COMPUTER NETWORKS", {37}, 3},
        {"COMPUTER ORGANIZATION AND ARCHITECTURE", {38}, 3},
        {"OPERATING SYSTEM", {25, 38}, 3},
        {"WEB TECHNOLOGIES", {39}, 3},
        {"ENGINEERING ETHICS", {38, 39}, 2},
        {"COMPILER DESIGN", {32}, 3},
        {"COMPUTER GRAPHICS", {25, 26}, 3},
        {"ENGINEERING MANAGEMENT", {44}, 3},
        {"RESEARCH METHODOLOGY", {}, 3},
        {"ADVANCE DATABASE MANAGEMENT SYSTEM", {18}, 3},
        {"BASIC MECHANICAL ENGG.", {11}, 3},
        {"COMPUTER SCIENCE MATHEMATICS", {25, 36}, 3},
        {"MANAGEMENT INFORMATION SYSTEM", {39}, 3},
        {"SIGNALS & LINEAR SYSTEM", {26}, 3},
        {"BASIC GRAPH THEORY", {25}, 3},
        {"DIGITAL SYSTEM DESIGN", {42}, 3},
        {"IMAGE PROCESSING", {47}, 3},
        {"MULTIMEDIA SYSTEMS", {44}, 3},
        {"SIMULATION & MODELING", {40}, 3},
        {"ENTERPRISE RESOURCE PLANNING", {39, 54}, 3},
        {"DATA WAREHOUSE AND DATA MINING", {83}, 3},
        {"NATURAL LANGUAGE PROCESSING", {40, 77}, 3},
        {"SOFTWARE DEVELOPMENT PROJECT MANAGEMENT", {67}, 3},
        {"HUMAN COMPUTER INTERACTION", {40, 44}, 3},
        {"ADVANCED COMPUTER NETWORKS", {41}, 3},
        {"SOFTWARE REQUIREMENT ENGINEERING", {39}, 3},
        {"COMPUTER VISION AND PATTERN RECOGNITION", {40, 47}, 3},
        {"LINEAR PROGRAMMING", {40, 32}, 3},
        {"NETWORK SECURITY", {41}, 3},
        {"SOFTWARE QUALITY AND TESTING", {67}, 3},
        {"ADVANCED OPERATING SYSTEM", {43}, 3},
        {"DIGITAL DESIGN WITH SYSTEM [VERILOG, VHDL & FPGAS]", {97}, 3},
        {"ROBOTICS ENGINEERING", {40}, 3},
        {"BUSINESS INTELLIGENCE AND DECISION SUPPORT", {61}, 3},
        {"TELECOMMUNICATIONS ENGINEERING", {37}, 3},
        {"PROGRAMMING IN PYTHON", {44}, 3},
        {"ADVANCED PROGRAMMING WITH JAVA", {44}, 3},
        {"ADVANCED PROGRAMMING WITH .NET", {44}, 3},
        {"ADVANCED PROGRAMMING IN WEB TECHNOLOGY", {44}, 3},
        {"ADVANCED ALGORITHM TECHNIQUES", {40}, 3},
        {"NETWORK RESOURCE MANAGEMENT & ORGANIZATION", {37, 41}, 3},
        {"INTRODUCTION TO DATA SCIENCE", {40}, 3},
        {"CYBER LAWS & INFORMATION SECURITY", {44}, 3},
        {"BIOINFORMATICS", {40}, 3},
        {"PARALLEL COMPUTING", {25, 40}, 3},
        {"MACHINE LEARNING", {40}, 3},
        {"WIRELESS SENSOR NETWORKS", {37, 41}, 3},
        {"INDUSTRIAL ELECTRONICS, DRIVES & INSTRUMENTATION", {30}, 3},
        {"MOBILE APPLICATION DEVELOPMENT", {44}, 3},
        {"SOFTWARE ARCHITECTURE AND DESIGN PATTERNS", {67}, 3},
        {"DIGITAL MARKETING", {44, 54}, 3},
        {"E-COMMERCE, E-GOVERNANCE & E-SERIES", {44}, 3},
        {"DIGITAL SIGNAL PROCESSING", {55}, 3},
        {"VLSI CIRCUIT DESIGN", {91}, 3}
    };
    // Print available courses
    printCourses(allCourses);
    courseDataUserInput(allCourses, "1");
}


// Function to handle EEE courses (dummy implementation for illustration)
void eeeCourses()
{
    vector<Course> allCourses =
    {
        // Semester 1
        {"CHEMISTRY", {}, 3},
        {"DIFFERENTIAL CALCULUS & CO-ORDINATE GEOMETRY", {}, 3},
        {"PHYSICS 1", {}, 3},
        {"PHYSICS 1 LAB", {1}, 1},
        {"ENGLISH READING SKILLS & PUBLIC SPEAKING", {}, 3},
        {"INTRODUCTION TO ENGINEERING STUDIES", {}, 1},
        //Semester 2
        {"BASIC MECHANICAL ENGINEERING", {3}, 3},
        {"ELECTICAL CIRCUIT-1 (DC)", {3, 5}, 3},
        {"ELECTICAL CIRCUIT-1 (DC) LAB", {6,4}, 1},
        {"INTEGRAL CALCULUS & ORDINARY DIFFERENTIAL EQUATIONS", {2}, 3},
        {"PHYSICS 2", {1, 3}, 3},
        {"PHYSICS 2 LAB", {1,4}, 1},
        {"PRINCIPLE OF ACCOUNTING", {2}, 3},
        {"ENGLISH WRITING SKILLS & COMMUNICATION", {4}, 3},
        // Semester 3
        {"COMPLEX VARIABLE, LAPLACE & Z-TRANSFORMATION", {10}, 3},
        {"ELECTRICAL CIRCUIT 2 (AC)", {3, 5}, 3},
        {"ELECTRICAL CIRCUITS-2 (AC) LAB",{9}, 1},
        {"ELECTRICAL MACHINES 1",{7, 16}, 3},
        {"ELECTRICAL MACHINES 1 LAB",{7, 16}, 1},
        {"ELECTRONIC DEVICES",{16}, 3},
        {"ELECTRONIC DEVICES LAB", {17}, 1},
        {"PROGRAMMING LANGUAGE 1 (STRUCTURED PROGRAMMING LANGUAGE)", {15}, 3},
        {"BANGLADESH STUDIES", {}, 3},
        // Semester 4
        {"ELECTRICAL MACHINES 2", {18}, 3},
        {"ELECTRICAL MACHINES 2 LAB", {19}, 1},
        {"ELECTRICAL POWER TRANSMISSION & DISTRIBUTION", {18}, 3},
        {"MATRICES,VECTORS,FOURIER ANALYSIS", {15}, 3},
        {"SIGNALS & LINEAR SYSTEMS", {27}, 3},
        {"ENGINEERING ETHICS AND ENVIRONMENTAL PROTECTION", {6}, 1},
        {"ANALOG ELECTRONICS",{20}, 3},
        {"ANALOG ELECTRONICS LAB", {21}, 1},
        {"COMPUTER AIDED DESIGN & DRAFTING",{8}, 1},
          // Semester 5
        {"MODERN PHYSICS", {11}, 3},
        {"ELECTROMAGNETICS FIELDS AND WAVES", {7, 11}, 3},
        {"PRINCIPLES OF ECONOMICS",{13}, 2},
        {"DIGITAL LOGIC AND CIRCUITS",{20}, 3},
        {"DIGITAL LOGIC AND CIRCUITS LAB",{21}, 1},
        {"ENGINEERING SHOP",{30}, 1},
        {"INDUSTRIAL ELECTRONICS AND DRIVES",{24}, 3},
        {"INDUSTRIAL ELECTRONICS AND DRIVES LAB",{25}, 1},
        {"DIGITAL SIGNAL PROCESSING",{27, 28}, 3},

         // Semester 6
        {"ELECTRICAL PROPERTIES OF MATERIALS", {33}, 3},
        {"PROGRAMMING LANGUAGE 2 (OBJECT ORIENTED PROGRAMMING LANGUAGE)", {22}, 3},
        {"POWER SYSTEMS ANALYSIS",{26}, 3},
        {"NUMERICAL METHODS FOR SCIENCE AND ENGINEERING",{27, 43}, 3},
        {"COMPUTATIONAL STATISTICS AND PROBABILITY",{34}, 3},
        {"PRINCIPLES OF COMMUNICATION",{34}, 3},
        // Semester 7

        {"BUSINESS COMMUNICATION",{14}, 3},
        {"ENGINEERING MANAGEMENT",{29}, 3},
        {"MODERN CONTROL SYSTEMS",{28}, 3},
        {"MODERN CONTROL SYSTEMS LAB", {28}, 1},
        {"MICROPROCESSOR AND EMBEDDED SYSTEM", {41, 43}, 3},

        // Semester 8
        {"INTERNSHIP/ SEMINAR/ WORKSHOP",{48},1},
        {"ELECTRICAL SERVICES DESIGN LAB",{38},1},
        {"TELECOMMUNICATIONS ENGINEERING",{47}, 3},
        {"TELECOMMUNICATIONS ENGINEERING",{44}, 3},
        {"MEASUREMENT AND INSTRUMENTATION",{50}, 3},
        {"VLSI CIRCUIT DESIGN",{41}, 3},
        {"CAPSTONE PROJECT", {}, 3},
    };

    printCourses(allCourses);
    cout << "\n\n";

    courseDataUserInput(allCourses, "2");

}


// Function to print available courses
void printCourses(const vector<Course>& courses)
{
    setTextColorGreen();
    cout << "\n\nAvailable Courses:\n";
    resetTextColor();
    for (size_t i = 0; i < courses.size(); ++i)
    {

         setTextColorYellow();
         cout << i + 1 << ". ";
         resetTextColor();
         cout<< courses[i].name << endl;
    }
}


void courseDataUserInput(vector<Course>allCourses, string dept, bool error)
{
    try
    {
        if(!error && !outOfRange) // Get completed courses from the user
            cout << "\n\nEnter completed course numbers or ranges (e.g., 1-10) separated by spaces: ";
        
        else if(!error && outOfRange)
            cout << "\n\nEnter valid completed course numbers or ranges (e.g., 1-10) separated by spaces: ";


        setTextColorGreen();
        string line;
        getline(cin, line);

        resetTextColor();
        // Parse input line
        vector<int> completedCourses = parseInput(line, dept);
        // Calculate total credit for completed courses
        int totalCreditCompleted = 0;
        for (int courseNum : completedCourses)
        {
            if (courseNum >= 1 && courseNum <= allCourses.size())
            {
                int index = courseNum - 1;
                totalCreditCompleted += allCourses[index].courseCredit;
            }
        }

        if(!outOfRange)
        {
            cout << "\nTotal credit completed: ";
            setTextColorYellow();
            cout<< totalCreditCompleted << endl;
            resetTextColor();

            recommendCourses(allCourses, completedCourses, totalCreditCompleted); // Recommend next semester courses
            repeatExecution(dept);
        }

        else
            courseDataUserInput(allCourses, dept, error);
        
        
    }

    catch(exception ex)
    {
        setTextColorRed();
        cout << "\nInvalid input format!\n";

        resetTextColor();
        cout << "Please enter course numbers separated by spaces, and specify ranges using a hyphen (e.g., 1-10): ";
        courseDataUserInput(allCourses, dept, true);
    }
}

// Helper function to parse input line into course numbers
vector<int> parseInput(const string& input, const string& dept)
{
    vector<int> courseNumbers;
    istringstream iss(input);
    string part;
    while (iss >> part)
    {
        size_t dashPos = part.find('-');

        try
        {
            // Single number
            if (dashPos == string::npos)
            {
                int number = stoi(part);
                if ((dept == "1" && number > 94) || (dept == "2" && number > 59))
                {
                    setTextColorRed();
                    cout << "Invalid Input: Number out of range" << endl;
                    resetTextColor();
                    outOfRange = true;

                    return courseNumbers;
                }

                else
                    courseNumbers.push_back(number);

            }

            // Range of numbers
            else
            {
                int start = stoi(part.substr(0, dashPos));
                int end = stoi(part.substr(dashPos + 1));
                for (int i = start; i <= end; ++i)
                {
                    if ((dept == "1" && i > 97) || (dept == "2" && i > 95))
                    {
                        setTextColorRed();
                        cout << "Invalid Input: Number out of range" << endl;
                        resetTextColor();
                        outOfRange = true;

                        return courseNumbers;
                    }
                    else
                        courseNumbers.push_back(i);

                }
            }
        }
        catch (const invalid_argument& e)
        {
            setTextColorRed();
            cout << "Invalid Input: Non-numeric value detected" << endl;
            resetTextColor();
        }
        catch (const out_of_range& e)
        {
            setTextColorRed();
            cout << "Invalid Input: Number out of range" << endl;
            resetTextColor();
        }
    }

    outOfRange = false;
    return courseNumbers;
}


// Function to recommend next semester courses
void recommendCourses(const vector<Course>& allCourses, const vector<int>& completedCourses, int totalCreditCompleted)
{
    // Store completed courses in a set for fast lookup
    unordered_set<int> completedSet(completedCourses.begin(), completedCourses.end());

    setTextColorGreen();
    cout << "\nRecommended Courses:\n";
    resetTextColor();


    for (size_t i = 0; i < allCourses.size(); ++i)
    {
        // Skip courses that have already been completed
        if (completedSet.find(i + 1) != completedSet.end())
            continue;

        const Course& course = allCourses[i];
        bool canTake = true;
        // Check if all prerequisites are completed
        for (int prereq : course.prerequisites)
        {
            if (completedSet.find(prereq) == completedSet.end())
            {
                canTake = false;
                break;
            }
        }

        // If total credit completed is less than 100, do not offer RESEARCH METHODOLOGY(if cse) or CAPSTONE PROJECT(if eee) course
        if ((course.name == "RESEARCH METHODOLOGY" || course.name == "CAPSTONE PROJECT") && totalCreditCompleted < 100)
            canTake = false;


        if (canTake)
        {
            //setTextColor();
            cout << "- " << course.name << " (" << course.courseCredit << ")" << endl;
            resetTextColor();
        }
    }
}
