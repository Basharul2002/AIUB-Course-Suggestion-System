using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace AIUB_Offered_Course
{
    public partial class CourseSolution : Form
    {
        public CourseSolution()
        {
            InitializeComponent();

            this.AcceptButton = department_choose_button;
            this.KeyPreview = true;
        }

        static bool outOfRange = false, inValidFormat = false, inValidNumber = false;
        private int departmentNumber = 0;
        private List<Course> allCourses;

        private enum CseCourse
        {
            CSC,
            COE,
            EEE,
            MIS,
            BAE
        }

        // Define a class to hold course information
        class Course
        {
            public string Name { get; set; }
            public HashSet<int> Prerequisites { get; set; }
            public int CourseCredit { get; set; }
            public int CourseType { get; set; }
            public int CourseDept { get; set; }

        }

        // Function to prompt the user to choose a department
        private void DepartmentOption()
        {
            departmentNumber = Int32.Parse(department_combobox.SelectedIndex.ToString());

            // if department number is 0 that means department is not selected
            if (departmentNumber == 0)
            {
                department_warning_label.Visible = true;
                return;
            }

            // if any deoartment selected than perform this function
            DepartmentChoose();
        }

        // Function to handle the department choice
        private void DepartmentChoose()
        {
            rightside_initial_state_panel.Visible = false;
            department_choosing_panel.Visible = false;
            course_chosing_panel.Visible = true;
            course_datagridview.Visible = true;
            offered_courses_panel.Visible = false;
            completed_course_number_button.Focus();
            this.AcceptButton = completed_course_number_button;
            GetPreviousControl(course_chosing_panel);

            if (departmentNumber == 1)
                CseCourses();
            else if (departmentNumber == 2)
                EeeCourses();
            else if (departmentNumber == 3)
                EnglishCourses();
        }

        // For comeback department choosing another panel 
        private void DepartmentEnviroment()
        {
            congratulation_panel.Visible = false;
            rightside_initial_state_panel.Visible = true;
            department_choosing_panel.Visible = true;
            course_chosing_panel.Visible = false;
            department_combobox.StartIndex = 0;
            course_datagridview.Visible = false;
            offered_courses_panel.Visible = false;

            department_warning_label.Visible = false;

            course_number_warning_label.Visible = false;
            course_number_textbox.Clear();

            this.AcceptButton = department_choose_button;

            departmentNumber = 0;
            inValidNumber = false;
        }

        // Function to handle CSE courses
        private void CseCourses()
        {
            allCourses = new List<Course>
                        {
                            // Semester 1
                            new Course { Name = "DIFFERENTIAL CALCULUS & CO-ORDINATE GEOMETRY", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1}, // 1
                            new Course { Name = "PHYSICS 1", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1 }, // 2
                            new Course { Name = "PHYSICS 1 LAB", Prerequisites = new HashSet<int>(), CourseCredit = 1, CourseType = 1 }, // 3
                            new Course { Name = "ENGLISH READING SKILLS & PUBLIC SPEAKING", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1 }, // 4
                            new Course { Name = "INTRODUCTION TO PROGRAMMING", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1 }, // 5
                            new Course { Name = "INTRODUCTION TO PROGRAMMING LAB", Prerequisites = new HashSet<int>(), CourseCredit = 1, CourseType = 1 }, // 6
                            new Course { Name = "INTRODUCTION TO COMPUTER STUDIES", Prerequisites = new HashSet<int>(), CourseCredit = 1, CourseType = 1 }, // 7

                            // Semester 2
                            new Course { Name = "DISCRETE MATHEMATICS", Prerequisites = new HashSet<int> { 1, 5 }, CourseCredit = 3, CourseType = 1 }, // 8
                            new Course { Name = "INTEGRAL CALCULUS & ORDINARY DIFFERENTIAL EQUATIONS", Prerequisites = new HashSet<int> { 1 }, CourseCredit = 3, CourseType = 1 }, // 9
                            new Course { Name = "OBJECT ORIENTED PROGRAMMING 1", Prerequisites = new HashSet<int> { 5, 6 }, CourseCredit = 3, CourseType = 1 }, // 10
                            new Course { Name = "PHYSICS 2", Prerequisites = new HashSet<int> { 2 }, CourseCredit = 3, CourseType = 1 }, // 11
                            new Course { Name = "PHYSICS 2 LAB", Prerequisites = new HashSet<int> { 3 }, CourseCredit = 1, CourseType = 1 }, // 12
                            new Course { Name = "ENGLISH WRITING SKILLS & COMMUNICATION", Prerequisites = new HashSet<int> { 4 }, CourseCredit = 3, CourseType = 1 }, // 13
                            new Course { Name = "INTRODUCTION TO ELECTRICAL CIRCUITS", Prerequisites = new HashSet<int> { 2 }, CourseCredit = 3, CourseType = 1 }, // 14 
                            new Course { Name = "INTRODUCTION TO ELECTRICAL CIRCUITS LAB", Prerequisites = new HashSet<int> { 3 }, CourseCredit = 1, CourseType = 1 }, // 15

                            // Semester 3
                            new Course { Name = "CHEMISTRY", Prerequisites = new HashSet<int> { 11 }, CourseCredit = 3, CourseType = 1 }, // 16
                            new Course { Name = "COMPLEX VARIABLE, LAPLACE & Z-TRANSFORMATION", Prerequisites = new HashSet<int> { 9 }, CourseCredit = 3, CourseType = 1 }, // 17
                            new Course { Name = "INTRODUCTION TO DATABASE", Prerequisites = new HashSet<int> { 10 }, CourseCredit = 3, CourseType = 1 }, // 18
                            new Course { Name = "ELECTRONIC DEVICES", Prerequisites = new HashSet<int> { 14 }, CourseCredit = 3, CourseType = 1 }, // 19
                            new Course { Name = "ELECTRONIC DEVICES LAB", Prerequisites = new HashSet<int> { 15 }, CourseCredit = 1, CourseType = 1 }, // 20 
                            new Course { Name = "PRINCIPLES OF ACCOUNTING", Prerequisites = new HashSet<int> { 9 }, CourseCredit = 3, CourseType = 1 }, // 21
                            new Course { Name = "DATA STRUCTURE", Prerequisites = new HashSet<int> { 8, 10 }, CourseCredit = 3, CourseType = 1}, // 22
                            new Course { Name = "DATA STRUCTURE LAB", Prerequisites = new HashSet<int> { 8, 10 }, CourseCredit = 1, CourseType = 1 }, // 23
                            new Course { Name = "COMPUTER AIDED DESIGN & DRAFTING", Prerequisites = new HashSet<int>(), CourseCredit = 1, CourseType = 1 }, // 24
                            
                            // Semester 4
                            new Course { Name = "ALGORITHMS", Prerequisites = new HashSet<int> { 22, 23 }, CourseCredit = 3, CourseType = 1 }, // 25
                            new Course { Name = "MATRICES, VECTORS, FOURIER ANALYSIS", Prerequisites = new HashSet<int> { 17 }, CourseCredit = 3, CourseType = 1 }, // 26
                            new Course { Name = "OBJECT ORIENTED PROGRAMMING 2", Prerequisites = new HashSet<int> { 18, 22 }, CourseCredit = 3, CourseType = 1 }, // 27
                            new Course { Name = "OBJECT ORIENTED ANALYSIS AND DESIGN", Prerequisites = new HashSet<int> { 18 }, CourseCredit = 3, CourseType = 1 }, // 28
                            new Course { Name = "BANGLADESH STUDIES", Prerequisites = new HashSet<int> { 7 }, CourseCredit = 3, CourseType = 1}, // 29
                            new Course { Name = "DIGITAL LOGIC AND CIRCUITS", Prerequisites = new HashSet<int> { 19 }, CourseCredit = 3, CourseType = 1 }, // 30
                            new Course { Name = "DIGITAL LOGIC AND CIRCUITS LAB", Prerequisites = new HashSet<int> { 20 }, CourseCredit = 1, CourseType = 1 }, // 31
                            new Course { Name = "COMPUTATIONAL STATISTICS AND PROBABILITY", Prerequisites = new HashSet<int> { 17 }, CourseCredit = 3, CourseType = 1 }, // 32
                            
                            // Semester 5
                            new Course { Name = "THEORY OF COMPUTATION", Prerequisites = new HashSet<int> { 25 }, CourseCredit = 3 , CourseType = 1}, // 33 
                            new Course { Name = "PRINCIPLES OF ECONOMICS", Prerequisites = new HashSet<int> { 32 }, CourseCredit = 2 , CourseType = 1}, // 34
                            new Course { Name = "BUSINESS COMMUNICATION", Prerequisites = new HashSet<int> { 29 }, CourseCredit = 3 , CourseType = 1}, // 35
                            new Course { Name = "NUMERICAL METHODS FOR SCIENCE AND ENGINEERING", Prerequisites = new HashSet<int> { 26 }, CourseCredit = 3, CourseType = 1 }, // 36
                            new Course { Name = "DATA COMMUNICATION", Prerequisites = new HashSet<int> { 30, 31 }, CourseCredit = 3, CourseType = 1 }, // 37
                            new Course { Name = "MICROPROCESSOR AND EMBEDDED SYSTEM", Prerequisites = new HashSet<int> { 30, 31 }, CourseCredit = 3, CourseType = 1}, // 38
                            new Course { Name = "SOFTWARE ENGINEERING", Prerequisites = new HashSet<int> { 27, 28 }, CourseCredit = 3 , CourseType = 1}, // 39
                            
                            // Semeter 6
                            new Course { Name = "ARTIFICIAL INTELLIGENCE AND EXPERT SYS.", Prerequisites = new HashSet<int> { 32, 33 }, CourseCredit = 3, CourseType = 1 },  // 40
                            new Course { Name = "COMPUTER NETWORKS", Prerequisites = new HashSet<int> { 37 }, CourseCredit = 3, CourseType = 1 }, // 41
                            new Course { Name = "COMPUTER ORGANIZATION AND ARCHITECTURE", Prerequisites = new HashSet<int> { 38 }, CourseCredit = 3, CourseType = 1 }, // 42
                            new Course { Name = "OPERATING SYSTEM", Prerequisites = new HashSet<int> { 33, 38 }, CourseCredit = 3, CourseType = 1 }, // 43
                            new Course { Name = "WEB TECHNOLOGIES", Prerequisites = new HashSet<int> { 39 }, CourseCredit = 3, CourseType = 1}, // 44
                            new Course { Name = "ENGINEERING ETHICS", Prerequisites = new HashSet<int> { 38, 39 }, CourseCredit = 2, CourseType = 1 }, // 45
                            new Course { Name = "COMPILER DESIGN", Prerequisites = new HashSet<int> { 33 }, CourseCredit = 3, CourseType = 1 }, // 46
                                     
                            // Semester 7
                            new Course { Name = "COMPUTER GRAPHICS", Prerequisites = new HashSet<int> { 26, 33 }, CourseCredit = 3, CourseType = 1 }, // 47
                            new Course { Name = "ENGINEERING MANAGEMENT", Prerequisites = new HashSet<int> { 45 }, CourseCredit = 3, CourseType = 1 }, // 48
                            new Course { Name = "RESEARCH METHODOLOGY", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1 }, // 49

                            // Change
                            // Semester 8
                            new Course { Name = "THESIS", Prerequisites= new HashSet<int> { 49 }, CourseCredit = 3, CourseType = 1}, // 50
                            new Course { Name = "INTERNSHIP", Prerequisites= new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 51

                            // ELECTIVE
                            // Information Systems
                            new Course { Name = "ADVANCE DATABASE MANAGEMENT SYSTEM", Prerequisites = new HashSet<int> { 18 }, CourseCredit = 3, CourseType = 2, CourseDept = 0}, // 52
                            new Course { Name = "MANAGEMENT INFORMATION SYSTEM", Prerequisites = new HashSet<int> { 39 }, CourseCredit = 3, CourseType = 2, CourseDept = 3 }, // 53
                            new Course { Name = "ENTERPRISE RESOURCE PLANNING", Prerequisites = new HashSet<int> { 39, 53 }, CourseCredit = 3, CourseType = 2, CourseDept = 3 }, // 54
                            new Course { Name = "DATA WAREHOUSE AND DATA MINING", Prerequisites = new HashSet<int> { 25, 32 }, CourseCredit = 3 , CourseType = 2, CourseDept = 0}, // 55
                            new Course { Name = "HUMAN COMPUTER INTERACTION", Prerequisites = new HashSet<int> { 40, 44 }, CourseCredit = 3 , CourseType = 2, CourseDept = 0}, // 56
                            new Course { Name = "BUSINESS INTELLIGENCE AND DECISION SUPPORT", Prerequisites = new HashSet<int> { 54 }, CourseCredit = 3 , CourseType = 2, CourseDept = 3}, // 57
                            new Course { Name = "INTRODUCTION TO DATA SCIENCE", Prerequisites = new HashSet<int> { 40 }, CourseCredit = 3 , CourseType = 2, CourseDept = 0}, // 58
                            new Course { Name = "CYBER LAWS & INFORMATION SECURITY", Prerequisites = new HashSet<int> { 44 }, CourseCredit = 3 , CourseType = 2, CourseDept = 0}, // 59
                            new Course { Name = "DIGITAL MARKETING", Prerequisites = new HashSet<int> { 44, 53 }, CourseCredit = 3 , CourseType = 2, CourseDept = 3}, // 60
                            new Course { Name = "E-COMMERCE, E-GOVERNANCE & E-SERIES", Prerequisites = new HashSet<int> { 44 }, CourseCredit = 3 , CourseType = 5, CourseDept = 3}, // 61

                            // Software Engineering
                            new Course { Name = "SOFTWARE DEVELOPMENT PROJECT MANAGEMENT", Prerequisites = new HashSet<int> { 63 }, CourseCredit = 3, CourseType = 3, CourseDept = 0 }, // 62
                            new Course { Name = "SOFTWARE REQUIREMENT ENGINEERING", Prerequisites = new HashSet<int> { 39 }, CourseCredit = 3, CourseType = 3, CourseDept = 0 }, // 63
                            new Course { Name = "SOFTWARE QUALITY AND TESTING", Prerequisites = new HashSet<int> { 63 }, CourseCredit = 3, CourseType = 3, CourseDept = 0 }, // 64
                            new Course { Name = "PROGRAMMING IN PYTHON", Prerequisites = new HashSet<int> { 44 }, CourseCredit = 3, CourseType = 3, CourseDept = 0 }, // 65
                            new Course { Name = "VIRTUAL REALITY SYSTEMS DESIGN", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3 , CourseType = 3, CourseDept = 0}, // 66
                            new Course { Name = "ADVANCED PROGRAMMING WITH JAVA", Prerequisites = new HashSet<int> { 44 }, CourseCredit = 3 , CourseType = 3, CourseDept = 0}, // 67
                            new Course { Name = "ADVANCED PROGRAMMING WITH .NET", Prerequisites = new HashSet<int> { 44 }, CourseCredit = 3 , CourseType = 3, CourseDept = 0}, // 68
                            new Course { Name = "ADVANCED PROGRAMMING IN WEB TECHNOLOGY", Prerequisites = new HashSet<int> { 44 }, CourseCredit = 3 , CourseType = 3, CourseDept = 0}, // 69
                            new Course { Name = "MOBILE APPLICATION DEVELOPMENT", Prerequisites = new HashSet<int> { 44 }, CourseCredit = 3 , CourseType = 3, CourseDept = 0}, // 70
                            new Course { Name = "SOFTWARE ARCHITECTURE AND DESIGN PATTERNS", Prerequisites = new HashSet<int> { 64 }, CourseCredit = 3 , CourseType = 3, CourseDept = 0}, // 71

                            // Computational Theory
                            new Course { Name = "COMPUTER SCIENCE MATHEMATICS", Prerequisites = new HashSet<int> { 25, 36 }, CourseCredit = 3 , CourseType = 4, CourseDept = 0}, // 72
                            new Course { Name = "BASIC GRAPH THEORY", Prerequisites = new HashSet<int> { 25 }, CourseCredit = 3, CourseType = 4, CourseDept = 0}, //73
                            new Course { Name = "ADVANCED ALGORITHM TECHNIQUES", Prerequisites = new HashSet<int> { 40 }, CourseCredit = 3, CourseType = 4, CourseDept = 0 }, // 74
                            new Course { Name = "NATURAL LANGUAGE PROCESSING", Prerequisites = new HashSet<int> { 40, 65 }, CourseCredit = 3, CourseType = 4, CourseDept = 0 }, // 75
                            new Course { Name = "LINEAR PROGRAMMING", Prerequisites = new HashSet<int> { 40, 32 }, CourseCredit = 3, CourseType = 4, CourseDept = 0 }, // 76
                            new Course { Name = "PARALLEL COMPUTING", Prerequisites = new HashSet<int> { 25, 40 }, CourseCredit = 3, CourseType = 4, CourseDept = 0 }, // 77
                            new Course { Name = "MACHINE LEARNING", Prerequisites = new HashSet<int> { 40 }, CourseCredit = 3, CourseType = 4, CourseDept = 0 }, // 78

                            // Computer Engineering                        
                            new Course { Name = "BASIC MECHANICAL ENGG.", Prerequisites = new HashSet<int> { 11 }, CourseCredit = 3, CourseType = 5, CourseDept = 4 }, // 79
                            new Course { Name = "SIGNALS & LINEAR SYSTEM", Prerequisites = new HashSet<int> { 26 }, CourseCredit = 3, CourseType = 5, CourseDept = 2 }, // 80
                            new Course { Name = "DIGITAL SYSTEM DESIGN", Prerequisites = new HashSet<int> { 42 }, CourseCredit = 3, CourseType = 5, CourseDept = 1 }, // 81
                            new Course { Name = "IMAGE PROCESSING", Prerequisites = new HashSet<int> { 47 }, CourseCredit = 3, CourseType = 5, CourseDept = 1}, // 82
                            new Course { Name = "MULTIMEDIA SYSTEMS", Prerequisites = new HashSet<int> { 44 }, CourseCredit = 3 , CourseType = 5, CourseDept = 1}, // 83
                            new Course { Name = "SIMULATION & MODELING", Prerequisites = new HashSet<int> { 40 }, CourseCredit = 3 , CourseType = 5, CourseDept = 1}, // 84
                            new Course { Name = "ADVANCED COMPUTER NETWORKS", Prerequisites = new HashSet<int> { 41 }, CourseCredit = 3 , CourseType = 5, CourseDept = 1}, // 85
                            new Course { Name = "COMPUTER VISION AND PATTERN RECOGNITION", Prerequisites = new HashSet<int> { 40, 47 }, CourseCredit = 3 , CourseType = 5, CourseDept = 1}, // 86
                            new Course { Name = "NETWORK SECURITY", Prerequisites = new HashSet<int> { 41 }, CourseCredit = 3 , CourseType = 5, CourseDept = 1}, // 87
                            new Course { Name = "ADVANCED OPERATING SYSTEM", Prerequisites = new HashSet<int> { 43 }, CourseCredit = 3 , CourseType = 5, CourseDept = 1}, // 88
                            new Course { Name = "DIGITAL DESIGN WITH SYSTEM [VERILOG, VHDL & FPGAS]", Prerequisites = new HashSet<int> { 96 }, CourseCredit = 3 , CourseType = 5, CourseDept = 2}, // 89
                            new Course { Name = "ROBOTICS ENGINEERING", Prerequisites = new HashSet<int> { 40 }, CourseCredit = 3 , CourseType = 5, CourseDept = 1}, // 90
                            new Course { Name = "TELECOMMUNICATIONS ENGINEERING", Prerequisites = new HashSet<int> { 37 }, CourseCredit = 3 , CourseType = 5, CourseDept = 2}, // 91
                            new Course { Name = "NETWORK RESOURCE MANAGEMENT & ORGANIZATION", Prerequisites = new HashSet<int> { 37, 41 }, CourseCredit = 3 , CourseType = 5, CourseDept = 1}, // 92
                            new Course { Name = "WIRELESS SENSOR NETWORKS", Prerequisites = new HashSet<int> { 37, 41 }, CourseCredit = 3 , CourseType = 5, CourseDept = 1}, // 93
                            new Course { Name = "INDUSTRIAL ELECTRONICS, DRIVES & INSTRUMENTATION", Prerequisites = new HashSet<int> { 30 }, CourseCredit = 3 , CourseType = 5, CourseDept = 2}, // 94
                            new Course { Name = "DIGITAL SIGNAL PROCESSING", Prerequisites = new HashSet<int> { 52 }, CourseCredit = 3 , CourseType = 5, CourseDept = 2}, // 95
                            new Course { Name = "VLSI CIRCUIT DESIGN", Prerequisites = new HashSet<int> { 94 }, CourseCredit = 3 , CourseType = 5, CourseDept = 2} // 96
                           // new Course { Name = "BIOINFORMATICS", Prerequisites = new HashSet<int> { 40 }, CourseCredit = 3 , CourseType = 5}
                        };

            PrintCourses(allCourses);
        }

        // Function to handle EEE courses
        private void EeeCourses()
        {
            allCourses = new List<Course>
            {
                // Semester 1
                new Course { Name = "CHEMISTRY", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1 }, //1
                new Course { Name = "DIFFERENTIAL CALCULUS & CO-ORDINATE GEOMETRY", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1 }, //2
                new Course { Name = "PHYSICS 1", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1 }, // 3
                new Course { Name = "PHYSICS 1 LAB", Prerequisites = new HashSet<int> (), CourseCredit = 1, CourseType = 1 }, // 4
                new Course { Name = "ENGLISH READING SKILLS & PUBLIC SPEAKING", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1 }, // 5
                new Course { Name = "INTRODUCTION TO ENGINEERING STUDIES", Prerequisites = new HashSet<int>(), CourseCredit = 1, CourseType = 1 }, // 6

                // Semester 2
                new Course { Name = "BASIC MECHANICAL ENGINEERING", Prerequisites = new HashSet<int> { 3 }, CourseCredit = 3, CourseType = 1 }, // 7
                new Course { Name = "ELECTICAL CIRCUIT-1 (DC)", Prerequisites = new HashSet<int> { 3, 6 }, CourseCredit = 3, CourseType = 1 }, // 8
                new Course { Name = "ELECTICAL CIRCUIT-1 (DC) LAB", Prerequisites = new HashSet<int> { 6, 4 }, CourseCredit = 1, CourseType = 1 }, // 9
                new Course { Name = "INTEGRAL CALCULUS & ORDINARY DIFFERENTIAL EQUATIONS", Prerequisites = new HashSet<int> { 2 }, CourseCredit = 3, CourseType = 1 }, // 10
                new Course { Name = "PHYSICS 2", Prerequisites = new HashSet<int> { 1, 3 }, CourseCredit = 3, CourseType = 1 }, // 11
                new Course { Name = "PHYSICS 2 LAB", Prerequisites = new HashSet<int> { 1, 4 }, CourseCredit = 1, CourseType = 1 }, // 12
                new Course { Name = "PRINCIPLE OF ACCOUNTING", Prerequisites = new HashSet<int> { 2 }, CourseCredit = 3, CourseType = 1 }, // 13
                new Course { Name = "ENGLISH WRITING SKILLS & COMMUNICATION", Prerequisites = new HashSet<int> { 5 }, CourseCredit = 3, CourseType = 1 }, // 14

                // Semester 3
                new Course { Name = "COMPLEX VARIABLE, LAPLACE & Z-TRANSFORMATION", Prerequisites = new HashSet<int> { 10 }, CourseCredit = 3, CourseType = 1 }, // 15
                new Course { Name = "ELECTRICAL CIRCUIT 2 (AC)", Prerequisites = new HashSet<int> { 8 }, CourseCredit = 3, CourseType = 1 }, // 16
                new Course { Name = "ELECTRICAL CIRCUITS-2 (AC) LAB", Prerequisites = new HashSet<int> { 9 }, CourseCredit = 1, CourseType = 1 }, // 17
                new Course { Name = "ELECTRICAL MACHINES 1", Prerequisites = new HashSet<int> { 7, 16 }, CourseCredit = 3, CourseType = 1 }, // 18
                new Course { Name = "ELECTRICAL MACHINES 1 LAB", Prerequisites = new HashSet<int> { 7, 17 }, CourseCredit = 1, CourseType = 1 }, // 19
                new Course { Name = "ELECTRONIC DEVICES", Prerequisites = new HashSet<int> { 16 }, CourseCredit = 3, CourseType = 1 }, // 20
                new Course { Name = "ELECTRONIC DEVICES LAB", Prerequisites = new HashSet<int> { 17 }, CourseCredit = 1, CourseType = 1 }, // 21
                new Course { Name = "PROGRAMMING LANGUAGE 1 (STRUCTURED PROGRAMMING LANGUAGE)", Prerequisites = new HashSet<int> { 10 }, CourseCredit = 3, CourseType = 1 }, // 22
                new Course { Name = "BANGLADESH STUDIES", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1 }, // 23

                // Semester 4
                new Course { Name = "ELECTRICAL MACHINES 2", Prerequisites = new HashSet<int> { 18 }, CourseCredit = 3, CourseType = 1 }, // 24
                new Course { Name = "ELECTRICAL MACHINES 2 LAB", Prerequisites = new HashSet<int> { 19 }, CourseCredit = 1, CourseType = 1 }, // 25
                new Course { Name = "ELECTRICAL POWER TRANSMISSION & DISTRIBUTION", Prerequisites = new HashSet<int> { 18 }, CourseCredit = 3, CourseType = 1 }, // 26
                new Course { Name = "MATRICES, VECTORS, FOURIER ANALYSIS", Prerequisites = new HashSet<int> { 15 }, CourseCredit = 3, CourseType = 1 }, // 27
                new Course { Name = "SIGNALS & LINEAR SYSTEMS", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 1 }, // 28
                new Course { Name = "ENGINEERING ETHICS AND ENVIRONMENTAL PROTECTION", Prerequisites = new HashSet<int> { 6 }, CourseCredit = 1, CourseType = 1 }, // 29
                new Course { Name = "ANALOG ELECTRONICS", Prerequisites = new HashSet<int> { 20 }, CourseCredit = 3, CourseType = 1 }, // 30
                new Course { Name = "ANALOG ELECTRONICS LAB", Prerequisites = new HashSet<int> { 21 }, CourseCredit = 1, CourseType = 1 }, // 31
                new Course { Name = "COMPUTER AIDED DESIGN & DRAFTING", Prerequisites = new HashSet<int> { 8 }, CourseCredit = 1, CourseType = 1 }, // 32

                // Semester 5
                new Course { Name = "MODERN PHYSICS", Prerequisites = new HashSet<int> { 11 }, CourseCredit = 3, CourseType = 1 }, // 33 
                new Course { Name = "ELECTROMAGNETICS FIELDS AND WAVES", Prerequisites = new HashSet<int> { 11, 27 }, CourseCredit = 3, CourseType = 1 }, // 34
                new Course { Name = "PRINCIPLES OF ECONOMICS", Prerequisites = new HashSet<int> { 13 }, CourseCredit = 2, CourseType = 1 }, // 35
                new Course { Name = "DIGITAL LOGIC AND CIRCUITS", Prerequisites = new HashSet<int> { 20 }, CourseCredit = 3, CourseType = 1 }, // 36
                new Course { Name = "DIGITAL LOGIC AND CIRCUITS LAB", Prerequisites = new HashSet<int> { 21 }, CourseCredit = 1, CourseType = 1 }, // 37
                new Course { Name = "ENGINEERING SHOP", Prerequisites = new HashSet<int> { 30 }, CourseCredit = 1, CourseType = 1 }, // 38
                new Course { Name = "INDUSTRIAL ELECTRONICS AND DRIVES", Prerequisites = new HashSet<int> { 24 }, CourseCredit = 3, CourseType = 1 }, // 39
                new Course { Name = "INDUSTRIAL ELECTRONICS AND DRIVES LAB", Prerequisites = new HashSet<int> { 25 }, CourseCredit = 1, CourseType = 1 }, // 40
                new Course { Name = "DIGITAL SIGNAL PROCESSING", Prerequisites = new HashSet<int> { 27, 28 }, CourseCredit = 3, CourseType = 1 }, // 41

                // Semester 6
                new Course { Name = "ELECTRICAL PROPERTIES OF MATERIALS", Prerequisites = new HashSet<int> { 33 }, CourseCredit = 3, CourseType = 1 }, // 42
                new Course { Name = "PROGRAMMING LANGUAGE 2 (OBJECT ORIENTED PROGRAMMING LANGUAGE)", Prerequisites = new HashSet<int> { 22 }, CourseCredit = 3, CourseType = 1 }, // 43
                new Course { Name = "POWER SYSTEMS ANALYSIS", Prerequisites = new HashSet<int> { 26 }, CourseCredit = 3, CourseType = 1 }, // 44
                new Course { Name = "NUMERICAL METHODS FOR SCIENCE AND ENGINEERING", Prerequisites = new HashSet<int> { 22, 27 }, CourseCredit = 3, CourseType = 1 }, // 45
                new Course { Name = "COMPUTATIONAL STATISTICS AND PROBABILITY", Prerequisites = new HashSet<int> { 45 }, CourseCredit = 3, CourseType = 1 }, // 46
                new Course { Name = "PRINCIPLES OF COMMUNICATION", Prerequisites = new HashSet<int> { 34 }, CourseCredit = 3, CourseType = 1 }, // 47

                // Semester 7
                new Course { Name = "BUSINESS COMMUNICATION", Prerequisites = new HashSet<int> { 14 }, CourseCredit = 3, CourseType = 1}, // 48
                new Course { Name = "ENGINEERING MANAGEMENT", Prerequisites = new HashSet<int> { 29 }, CourseCredit = 3, CourseType = 1}, // 49
                new Course { Name = "MODERN CONTROL SYSTEMS", Prerequisites = new HashSet<int> { 28 }, CourseCredit = 3, CourseType = 1 }, // 50
                new Course { Name = "MODERN CONTROL SYSTEMS LAB", Prerequisites = new HashSet<int> { 28 }, CourseCredit = 1, CourseType = 1 }, // 51
                new Course { Name = "MICROPROCESSOR AND EMBEDDED SYSTEM", Prerequisites = new HashSet<int> { 36, 43 }, CourseCredit = 3, CourseType = 1 }, // 52
                new Course { Name = "CAPSTONE PROJECT 1", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 53

                // Semester 8
                new Course { Name = "INTERNSHIP/ SEMINAR/ WORKSHOP", Prerequisites = new HashSet<int> { 48 }, CourseCredit = 1, CourseType = 1 }, // 54
                new Course { Name = "ELECTRICAL SERVICES DESIGN LAB", Prerequisites = new HashSet<int> { 38 }, CourseCredit = 1, CourseType = 1 }, // 55
                new Course { Name = "TELECOMMUNICATIONS ENGINEERING", Prerequisites = new HashSet<int> { 47 }, CourseCredit = 3, CourseType = 1 }, // 56
                new Course { Name = "POWER STATIONS AND SUBSTATIONS", Prerequisites = new HashSet<int> { 44 }, CourseCredit = 3, CourseType = 1 }, // 57
                new Course { Name = "MEASUREMENT AND INSTRUMENTATION", Prerequisites = new HashSet<int> { 50 }, CourseCredit = 3, CourseType = 1 }, // 58
                new Course { Name = "VLSI CIRCUIT DESIGN", Prerequisites = new HashSet<int> { 36 }, CourseCredit = 3, CourseType = 1 }, //59
                new Course { Name = "CAPSTONE PROJECT 2", Prerequisites = new HashSet<int> { 29, 48 }, CourseCredit = 2, CourseType = 1 }, //60

                
                // Elective course
                new Course { Name = "COMPUTER SYSTEM ARCHITECTURE", Prerequisites = new HashSet<int> { 52 }, CourseCredit = 3, CourseType = 2},
                new Course { Name = "MICROWAVE ENGINEERING", Prerequisites = new HashSet<int> { 34 }, CourseCredit = 3, CourseType = 2},
                new Course { Name = "COMPUTER INTERFACE DESIGN", Prerequisites = new HashSet<int> { 52 }, CourseCredit = 3,CourseType = 2 },
                new Course { Name = "OPTOELECTRONIC DEVICES", Prerequisites = new HashSet<int> { 47 }, CourseCredit = 3, CourseType = 2 },
                new Course { Name = "POWER SYSTEM PROTECTION", Prerequisites = new HashSet<int> { 44 }, CourseCredit = 3, CourseType = 2 },
                new Course { Name = "CELLULAR MOBILE COMMUNICATION", Prerequisites = new HashSet<int> { 56 }, CourseCredit = 3, CourseType = 2 },
                new Course { Name = "DIGITAL DESIGN WITH SYSTEM [ VERILOG,VHDL & FPGAS ]", Prerequisites = new HashSet<int> { 59 }, CourseCredit = 3, CourseType = 2 },
                new Course { Name = "INTRODUCTION TO ANIMATION", Prerequisites = new HashSet<int> { 43 }, CourseCredit = 3, CourseType = 2 },
                new Course { Name = "ROBOTICS ENGINEERING", Prerequisites = new HashSet<int> { 50 }, CourseCredit = 3, CourseType = 2 },
                new Course { Name = "RENEWABLE ENERGY TECHNOLOGY", Prerequisites = new HashSet<int> { 44 }, CourseCredit = 3, CourseType = 2 },
                new Course { Name = "BIOMEDICAL INSTRUMENTATION MEASUREMENT AND DESIGN", Prerequisites = new HashSet<int> { 58 }, CourseCredit = 3, CourseType = 2 },
                new Course { Name = "NUCLEAR POWER ENGINEERING", Prerequisites = new HashSet<int> { 57 }, CourseCredit = 3, CourseType = 2 },
                new Course { Name = "SOFTWARE ENGINEERING", Prerequisites = new HashSet<int> { 43 }, CourseCredit = 3, CourseType = 2 },
                new Course { Name = "NANOTECHNOLOGY FOR ENGINEERS", Prerequisites = new HashSet<int> { 42 }, CourseCredit = 3, CourseType = 2 },
            };

            PrintCourses(allCourses);
        }

        // Function to handle English courses
        private void EnglishCourses()
        {
            allCourses = new List<Course>
            {
                // Semester 1
                new Course { Name = "ENGLISH READING SKILLS & PUBLIC SPEAKING", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1}, //1
                new Course { Name = "BANGLA LANGUAGE AND LITERATURE", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1}, // 2
                new Course { Name = "FOUNDATIONS OF SOCIOLOGY", Prerequisites= new HashSet<int>(), CourseCredit = 3, CourseType = 1}, // 3
                new Course { Name = "COMPUTER FUNDAMENTALS", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1}, // 4
                new Course { Name = "INTRODUCTION TO ENGLISH LITERATURE", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1}, // 5
                new Course { Name = "INTRODUCTION TO LINGUISTICS", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1}, // 6


                // Semester 2
                new Course { Name = "ENGLISH WRITING", Prerequisites = new HashSet<int> {1}, CourseCredit = 3, CourseType = 1}, // 7
                new Course { Name = "ENGLISH WRITING", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 8
                new Course { Name = "HISTORY OF EMERGENCE OF BANGLADESH", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 9
                new Course { Name = "APPRECIATION OF POETRY", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 10
                new Course { Name = "FUNDAMENTALS OF ECONOMICS", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1 }, // 11
                new Course { Name = "NATURAL SCIENCE", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 12


                // Semester 3
                new Course { Name = "WRITING FOR ARTS AND SOCIAL SCIENCES", Prerequisites = new HashSet<int> {7}, CourseCredit = 3, CourseType = 1}, // 13
                new Course { Name = "BANGLADESH STUDIES", Prerequisites = new HashSet<int> {9}, CourseCredit = 3, CourseType = 1}, // 14
                new Course { Name = "ARTS AND AESTHETICS", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 15
                new Course { Name = "STATISTICS FOR SOCIAL SCIENCE", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 16
                new Course { Name = "HISTORY OF ENGLISH LANGUAGE", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 17
                new Course { Name = "ELEMENTARY ACCOUNTING", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 18


                // Semester 4
                new Course { Name = "APPRECIATION OF PROSE", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 19
                new Course { Name = "CLASSROOM MANAGEMENT TECHNIQUES IN ELT", Prerequisites = new HashSet<int> {6}, CourseCredit = 3, CourseType = 1 }, //20
                new Course { Name = "APPRECIATION OF DRAMA", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1 }, // 21
                new Course { Name = "PROFESSIONAL ENGLISH", Prerequisites = new HashSet<int> {7}, CourseCredit = 3, CourseType = 1}, // 22
                new Course { Name = "SOCIAL SCIENCE RESEARCH METHODOLOGY", Prerequisites = new HashSet<int> {16}, CourseCredit = 3, CourseType = 1 }, // 23
                new Course { Name = "COGNITIVE AND SOCIAL PSYCHOLOGY", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 24


                // Semester 5
                new Course { Name = "PHILOSOPHY AND ETHICS", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, //25
                new Course { Name = "CLASSICAL LITERATURE", Prerequisites = new HashSet<int> {21}, CourseCredit = 3, CourseType = 1}, // 26
                new Course { Name = "FIRST LANGUAGE DEVELOPMENT", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 27
                new Course { Name = "TEACHING GRAMMAR AND VOCABULARY", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1}, // 28


                // Semester 6
                new Course { Name = "PHONETICS AND PHONOLOGY", Prerequisites = new HashSet<int> {8}, CourseCredit = 3, CourseType = 1},  // 29
                new Course { Name = "CONTEMPORARY SOUTH ASIAN LITERATURE IN ENGLISH", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 30
                new Course { Name = "ELT APPROACHES AND METHODS", Prerequisites = new HashSet<int> {20}, CourseCredit = 3, CourseType = 1}, // 31
                new Course { Name = "SOUTH ASIAN HISTORY AND DEVELOPMENT", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 32


                // Semeseter 7
                new Course { Name = "SHAKESPEARE", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 33
                new Course { Name  = "LITERARY THEORY AND CRITICISM", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1}, // 34
                new Course { Name = "SOCIOLINGUISTICS", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1 }, // 35


                // Semester 8
                new Course { Name = "PROFESSIONAL DEVELOPMENT", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1 }, // 36
                new Course { Name = "PROFESSIONAL DEVELOPMENT", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1 }, // 37
                new Course { Name = "TEACHING PRACTICUM", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1 }, // 38


                // Elecetive
                // Major in Linguistics & TESL
                new Course { Name = "ENGLISH SYNTAX", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 2 }, // 39
                new Course { Name = "SEMANTICS AND PRAGMATICS", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 2 }, // 40
                new Course { Name = "DISCOURSE ANALYSIS", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1 }, // 41
                new Course { Name = "GLOBAL ENGLISHES", Prerequisites = new HashSet<int> (), CourseCredit = 3 , CourseType = 2}, // 42
                new Course { Name = "SECOND LANGUAGE ACQUISITION", Prerequisites = new HashSet<int> (), CourseCredit = 3 , CourseType = 2}, // 43
                new Course { Name = "BILINGUALISM", Prerequisites = new HashSet<int> (), CourseCredit = 3 , CourseType = 2}, // 44
                new Course { Name = "TECHNOLOGY IN LANGUAGE LEARNING", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 2}, // 45
                new Course { Name = "LANGUAGE TESTING", Prerequisites = new HashSet<int> (), CourseCredit = 3 , CourseType = 2}, // 46
                new Course { Name = "ENGLISH FOR SPECIFIC PURPOSES", Prerequisites = new HashSet<int> (), CourseCredit = 3 , CourseType = 2}, // 47
                new Course { Name = "TEACHING READING", Prerequisites = new HashSet<int> (), CourseCredit = 3 , CourseType = 2}, // 48
                new Course { Name = "TEACHING LISTENING AND SPEAKING", Prerequisites = new HashSet<int> (), CourseCredit = 3 , CourseType = 2}, // 49
                new Course { Name = "GLOBAL LANGUAGE", Prerequisites = new HashSet<int> (), CourseCredit = 3 , CourseType = 2}, // 50
                new Course { Name = "INDEPENDENT PROJECT", Prerequisites = new HashSet<int> (), CourseCredit = 3 , CourseType = 2}, // 51



                // Major In Literature
                new Course { Name = "OLD AND MIDDLE ENGLISH LITERATURE", Prerequisites = new HashSet<int> (), CourseCredit = 3 , CourseType = 3}, // 52
                new Course { Name = "ROMANTIC POETRY", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 3 }, // 53
                new Course { Name = "VICTORIAN LITERATURE", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 3 }, // 54
                new Course { Name = "MODERN FICTION AND NON-FICTION", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 3 }, // 55
                new Course { Name = "MODERN DRAMA AND POETRY", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 3 }, // 56
                new Course { Name = "AMERICAN LITERATURE", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 3 }, // 57
                new Course { Name = "AFRICAN LITERATURE IN ENGLISH", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 3 }, // 58
                new Course { Name = "16TH AND 17TH CENTURY ENGLISH LITERATURE", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 3 }, // 59
                new Course { Name = "TRANSLATION STUDIES", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 3 }, // 60
                new Course { Name = "EUROPEAN LITERATURE IN ENGLISH", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 3}, //61
                new Course { Name = "CARIBBEAN LITERATURE IN ENGLISH", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 3 }, // 62
                new Course { Name = "TEACHING ENGLISH LITERATURE", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 3 }, // 63
                new Course { Name = "BANGLADESHI LITERATURE IN ENGLISH", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 3}, // 64
                new Course { Name = "CREATIVE WRITING", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 3 }, // 65
                new Course { Name = "GLOBAL LANGUAGES", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 3 }, // 66
                new Course { Name = "INDEPENDENT PROJECT", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 3 } // 67
            };

            PrintCourses(allCourses);
        }

        // Function to print available courses
        private void PrintCourses(List<Course> courses)
        {
            // Clear existing columns (if any)
            course_datagridview.Rows.Clear();

            // Iterate through all courses
            for (int i = 0; i < courses.Count; i++)
            {
                // Add a new row(Course ID, Name, Number of credit) to DataGridView for each course
                course_datagridview.Rows.Add
                (
                    $"{i + 1}" ,
                    $"{courses[i].Name} ", 
                    $"{courses[i].CourseCredit}"
                );
            }
        }

        // Proceses user input (Course numbers)
        private void CourseDataUserInput(string input, List<Course> allCourses, int dept, bool error = false)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                course_number_warning_label.Visible = true;
                course_number_warning_label.Text = "**Please Enter Course ID**";
                return;
            }

            try
            {
                List<int> completedCourses = ParseInput(input, dept);

                // Check for duplicate course IDs
                if (completedCourses.Count != completedCourses.Distinct().Count())
                {
                    course_number_warning_label.Text = "**Duplicate Course IDs Are Not Allowed**";
                    course_number_warning_label.Visible = true;
                    return;
                }

                if (!InvalidSequence(completedCourses))
                {
                    course_number_warning_label.Text = "**Invalid Course ID Sequence!**";
                    course_number_warning_label.Visible = true;
                    return;
                }

                int totalCreditCompleted = 0;
                foreach (int courseNum in completedCourses)
                {
                    if (courseNum >= 1 && courseNum <= allCourses.Count)
                        totalCreditCompleted += allCourses[courseNum - 1].CourseCredit;
                    else
                        outOfRange = true;
                }

                if (outOfRange || inValidFormat)
                {
                    if (inValidFormat)
                        course_number_warning_label.Text = "**Invalid Input Format**";
                    else if (outOfRange)
                        course_number_warning_label.Text = "**Invalid Input**";

                    core_courses_datagridview.Rows.Clear();
                    course_number_warning_label.Visible = true;
                    DepartmentChoose();

                    return;
                }

                int notCompletedPrerequisitCourseNumber;
                if (!ValidatePrerequisites(completedCourses, allCourses, totalCreditCompleted, out notCompletedPrerequisitCourseNumber))
                {
                    // Find the first course with incomplete prerequisites
                    notCompletedPrerequisitCourseNumber = FindCourseWithIncompletePrerequisites(completedCourses, allCourses);

                    course_number_warning_label.Text = $"Some Prerequisites are Not Completed.";
                    course_number_warning_label.Visible = true;

                    offered_courses_panel.Visible = false;
                    course_datagridview.Visible = true;
                    return;
                }

                congratulation_panel.Visible = false;
                course_number_warning_label.Visible = false;
                course_datagridview.Visible = false;

                if ((dept == 1 && totalCreditCompleted == 262) || (dept == 2 && totalCreditCompleted == 184))
                {
                    congratulation_panel.Visible = true;
                    return;
                }

                course_number_warning_label.Visible = false;
                course_datagridview.Visible = false;
                offered_courses_panel.Visible = true;

                course_heading_label.Text = $"Total credit completed: {totalCreditCompleted} \t\nRecommended courses you can take next semester";

                RecommendCourses(allCourses, completedCourses, totalCreditCompleted);
            }
            catch (Exception ex)
            {
               // MessageBox.Show($"Function name is CourseDataUserInput and error: {ex.Message}");
                course_number_warning_label.Text = "Duplicate Course IDs are Not Allowed";
                course_number_warning_label.Visible = true;
            }
        }

        // Helper function to find the course with incomplete prerequisites
        private int FindCourseWithIncompletePrerequisites(List<int> completedCourses, List<Course> allCourses)
        {
            var completedCoursesSet = new HashSet<int>(completedCourses);

            for (int i = 0; i < allCourses.Count; i++)
            {
                if (!completedCoursesSet.Contains(i + 1))
                {
                    var prerequisites = allCourses[i].Prerequisites;
                    if (!prerequisites.All(prereq => completedCoursesSet.Contains(prereq)))
                    {
                        return i + 1;
                    }
                }
            }

            // No course found with incomplete prerequisites
            return -1;
        }
        // Helper function to parse input line into course numbers
        private List<int> ParseInput(string input, int dept)
        {
            List<int> courseNumbers = new List<int>();
            var parts = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            outOfRange = false;
            inValidFormat = false;
            bool hasDuplicates = false;

            HashSet<int> uniqueNumbers = new HashSet<int>();

            foreach (var part in parts)
            {
                try
                {
                    if (!part.Contains('-'))
                    {
                        int number = int.Parse(part.Trim());
                        if (IsValidCourseNumber(number, dept))
                        {
                            if (!uniqueNumbers.Add(number))
                            {
                                hasDuplicates = true;
                                break;
                            }
                            courseNumbers.Add(number);
                        }
                        else
                        {
                            outOfRange = true;
                            break;
                        }
                    }
                    else
                    {
                        var rangeParts = part.Split('-');
                        if (rangeParts.Length == 2 && int.TryParse(rangeParts[0].Trim(), out int start) && int.TryParse(rangeParts[1].Trim(), out int end))
                        {
                            for (int i = start; i <= end; i++)
                            {
                                if (IsValidCourseNumber(i, dept))
                                {
                                    if (!uniqueNumbers.Add(i))
                                    {
                                        hasDuplicates = true;
                                        break;
                                    }
                                    courseNumbers.Add(i);
                                }
                                else
                                {
                                    outOfRange = true;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            inValidFormat = true;
                            break;
                        }
                    }
                }
                catch (FormatException)
                {
                    inValidFormat = true;
                    break;
                }
                catch (OverflowException)
                {
                    inValidFormat = true;
                    break;
                }

                if (hasDuplicates)
                {
                    break;
                }
            }

            if (hasDuplicates)
            {
                throw new ArgumentException("Duplicate course IDs are not allowed.");
            }

            return courseNumbers;
        }
        private bool InvalidSequence(List<int> sequence)
        {
            for (int i = 1; i < sequence.Count; i++)
            {
                if (sequence[i] < sequence[i - 1])
                    return false;
                
            }
            return true;
        }

        private bool IsValidCourseNumber(int number, int dept)
        {
            return (dept == 1 && number <= 99) || (dept == 2 && number <= 74) || (dept == 3 && number <= 67);
        }

        // Validate prerequisites for each inputted course
        private bool ValidatePrerequisites(List<int> completedCourses, List<Course> allCourses, int totalCreditCompleted, out int mess)
        {
            var completedCoursesSet = new HashSet<int>(completedCourses);

            foreach (int courseNum in completedCourses)
            {
                if (courseNum >= 1 && courseNum <= allCourses.Count)
                {
                    var course = allCourses[courseNum - 1];
                    var prerequisites = course.Prerequisites;

                    // Check if all prerequisites are completed
                    if (!prerequisites.All(prereq => completedCoursesSet.Contains(prereq)))
                    {
                        mess = courseNum;
                        return false;
                    }

                    // Check for "RESEARCH METHODOLOGY" course with less than 100 completed credits
                    if ((course.Name == "RESEARCH METHODOLOGY" && totalCreditCompleted < 100)  || (course.Name == "INTERNSHIP" && totalCreditCompleted < 139) // CSE
                        || (course.Name == "CAPSTONE PROJECT 1" && totalCreditCompleted < 105)  // EEE
                        || (departmentNumber == 2 && (course.CourseType == 2 || course.CourseType == 3) && totalCreditCompleted < 60)) // English
                    {
                        mess = courseNum;
                        return false;
                    }
                }
            }

            mess = 0;
            return true;
        }


        private void SetupDataGridViews()
        {
            // Clear existing rows and columns in DataGridViews
            ClearDataGridViews();

            if (departmentNumber == 1)
            {
                SetupDataGridView(elective1_courses_datagridview, "<b>Major in Information</b>", new int[] { 326, 58, 91 }, DataGridViewContentAlignment.MiddleCenter);
                SetupDataGridView(elective2_courses_datagridview, "<b>Major in Software Engineering</b>", new int[] { 326, 58, 91 }, DataGridViewContentAlignment.MiddleCenter);
                SetupDataGridView(elective3_courses_datagridview, "<b>Major in Computational Theory</b>", new int[] { 326, 58, 91 }, DataGridViewContentAlignment.MiddleCenter);
                SetupDataGridView(elective4_courses_datagridview, "<b>Major in Computer Engineering</b>", new int[] { 326, 58, 91 }, DataGridViewContentAlignment.MiddleCenter);
            }
            else if (departmentNumber == 2)
                SetupDataGridView(elective1_courses_datagridview, "", new int[] { 417, 58 }, DataGridViewContentAlignment.MiddleCenter);
            
            else if (departmentNumber == 3)
            {
                SetupDataGridView(elective1_courses_datagridview, "<b>Major in Linguistics & TESL</b>  <br>First Major: Complete any 10 courses in Linguistics & TESL <br> Second Major: Complete any 6 courses in Linguistics & TESL <br>Minor: Complete any FOUR 4 courses in Linguistics & TESL", new int[] { 417, 58 }, DataGridViewContentAlignment.MiddleCenter);
                SetupDataGridView(elective2_courses_datagridview, "<b>Major In Literature</b> <br>First Major: Complete any 10 courses in Literature <br> Second Major: Complete any 6 courses in Literature <br>Minor: Complete any FOUR 4 courses in Literature", new int[] { 417, 58 }, DataGridViewContentAlignment.MiddleCenter);
            }

            
            HideAllDataGridViews();
        }

        private void ClearDataGridViews()
        {
            core_courses_datagridview.Rows.Clear();
            elective1_courses_datagridview.Columns.Clear();
            elective2_courses_datagridview.Columns.Clear();
            elective3_courses_datagridview.Columns.Clear();
            elective4_courses_datagridview.Columns.Clear();
            elective1_courses_datagridview.Rows.Clear();
            elective2_courses_datagridview.Rows.Clear();
            elective3_courses_datagridview.Rows.Clear();
            elective4_courses_datagridview.Rows.Clear();
        }

        private void SetupDataGridView(DataGridView dgv, string labelText, int[] columnWidths, DataGridViewContentAlignment alignment)
        {
            // Add columns
            dgv.Columns.Add("CourseName", "Course Name");
            dgv.Columns.Add("CourseCredit", "Credit");
            if (columnWidths.Length == 3)
                dgv.Columns.Add("CourseType", "Course Type");
            

            // Set properties
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Dock = DockStyle.Top;

            // Set column widths
            for (int i = 0; i < columnWidths.Length; i++)
            {
                dgv.Columns[i].Width = columnWidths[i];
                if (i > 0) // Center align second and third columns
                    dgv.Columns[i].DefaultCellStyle.Alignment = alignment;
                
            }

            // Set header alignment
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Set the label text
            if (dgv == elective1_courses_datagridview)
            {
                elective1_courses_label.Text = labelText;
                elective1_courses_label.AutoSize = true;
            }
            else if (dgv == elective2_courses_datagridview)
            {
                elective2_courses_label.Text = labelText;
                elective2_courses_label.AutoSize = true;
            }
            else if (dgv == elective3_courses_datagridview)
            {
                elective3_courses_label.Text = labelText;
                elective3_courses_label.AutoSize = true;
            }
            else if (dgv == elective4_courses_datagridview)
            {
                elective4_courses_label.Text = labelText;
                elective4_courses_label.AutoSize = true;
            }
        }

        private void HideAllDataGridViews()
        {
            core_courses_label.Visible = false;
            elective1_courses_label.Visible = false;
            elective2_courses_label.Visible = false;
            elective3_courses_label.Visible = false;
            elective4_courses_label.Visible = false;
            elective_courses_label.Visible = false;

            core_courses_datagridview.Visible = false;
            elective1_courses_datagridview.Visible = false;
            elective2_courses_datagridview.Visible = false;
            elective3_courses_datagridview.Visible = false;
            elective4_courses_datagridview.Visible = false;
        }


        // Function to recommend courses based on prerequisites and completed courses
        private void RecommendCourses(List<Course> allCourses, List<int> completedCourses, int totalCreditCompleted)
        {
            var completedCoursesSet = new HashSet<int>(completedCourses);

            SetupDataGridViews();



            recomended_courses_panel.Visible = true;
            // Iterate through all courses
            for (int i = 0, j = 1, k = 1, l = 1, m = 1, n = 1; i < allCourses.Count; i++)
            {
                // Skip if course is already completed
                if (completedCoursesSet.Contains(i + 1))
                    continue;

                var prerequisites = allCourses[i].Prerequisites;

                // Check if all prerequisites are completed
                if (!prerequisites.All(prereq => completedCoursesSet.Contains(prereq)))
                    continue;

                // Skip "RESEARCH METHODOLOGY" and "CAPSTONE PROJECT" if total credits completed < 100
                if (((allCourses[i].Name == "RESEARCH METHODOLOGY" && totalCreditCompleted < 100) || (allCourses[i].Name == "INTERNSHIP" && totalCreditCompleted < 139)) // CSE
                    || (allCourses[i].Name == "CAPSTONE PROJECT 1" && totalCreditCompleted < 105) // EEE
                    || (departmentNumber == 3 && (allCourses[i].CourseType == 2 || allCourses[i].CourseType== 3) && totalCreditCompleted < 60))
                    continue;

                // Add a new row to DataGridView for recommended course
                if (allCourses[i].CourseType == 1)
                {
                    core_courses_datagridview.Rows.Add
                    (
                        $"{j++}. {allCourses[i].Name}", // Display course number and name
                        $"{allCourses[i].CourseCredit}"
                    );
                }

                if (departmentNumber == 1)
                {
                    // Add a new row to DataGridView for recommended elective course 
                    if (allCourses[i].CourseType == 2)
                    {
                        elective1_courses_datagridview.Rows.Add
                        (
                            $"{k++}. {allCourses[i].Name}", // Placeholder text for merged cells
                            $"{allCourses[i].CourseCredit}",
                            $"{(CseCourse)allCourses[i].CourseDept}"
                        );
                    }



                    // Add a new row to DataGridView for recommended elective course 
                    else if (allCourses[i].CourseType == 3)
                    {
                        elective2_courses_datagridview.Rows.Add
                        (
                            $"{l++}. {allCourses[i].Name}", // Placeholder text for merged cells
                            $"{allCourses[i].CourseCredit}",
                            $"{(CseCourse)allCourses[i].CourseDept}"
                        );
                    }


                    // Add a new row to DataGridView for recommended elective course 
                    if (allCourses[i].CourseType == 4)
                    {
                        elective3_courses_datagridview.Rows.Add
                        (
                            $"{m++}. {allCourses[i].Name}", // Placeholder text for merged cells
                            $"{allCourses[i].CourseCredit}",
                            $"{(CseCourse)allCourses[i].CourseDept}"
                        );
                    }


                    // Add a new row to DataGridView for recommended elective course 
                    if (allCourses[i].CourseType == 5)
                    {
                        elective4_courses_datagridview.Rows.Add
                        (
                            $"{n++}. {allCourses[i].Name}", // Placeholder text for merged cells
                            $"{allCourses[i].CourseCredit}",
                            $"{(CseCourse)allCourses[i].CourseDept}"
                        );
                    }
                }

                else if (departmentNumber == 2)
                {
                    if (allCourses[i].CourseType == 2)
                    {
                        elective1_courses_datagridview.Rows.Add
                        (
                            $"{k++}. {allCourses[i].Name}", // Placeholder text for merged cells
                            $"{allCourses[i].CourseCredit}"
                        );
                    }
                }

                else if ( departmentNumber == 3)
                {
                    if (allCourses[i].CourseType == 2)
                    {
                        elective1_courses_datagridview.Rows.Add
                        (
                            $"{k++}. {allCourses[i].Name}", // Placeholder text for merged cells
                            $"{allCourses[i].CourseCredit}"
                        );
                    }



                    // Add a new row to DataGridView for recommended elective course 
                    else if (allCourses[i].CourseType == 3)
                    {
                        elective2_courses_datagridview.Rows.Add
                        (
                            $"{l++}. {allCourses[i].Name}", // Placeholder text for merged cells
                            $"{allCourses[i].CourseCredit}"
                        );
                    }
                }
                
            }

            AdjustAllDataGridViews();

            int electiveCourse = 0;
            if (core_courses_datagridview.Rows.Count > 0)
            {
                core_courses_datagridview.Visible = true;
                core_courses_label.Visible = true;
            }
            else
            {
                core_courses_datagridview.Visible = false;
                core_courses_label.Visible = false;
            }

            // Check if there are any elective courses
            if (elective1_courses_datagridview.Rows.Count > 0)
            {
                electiveCourse = (departmentNumber != 1) ? 1 : 0;
                elective1_courses_label.Visible = true;
                elective1_courses_datagridview.Visible = true;
                elective1_courses_datagridview.Dock = DockStyle.Top;
            }
            else
            {
                elective1_courses_label.Visible = false;
                elective1_courses_datagridview.Visible = false;
            }

            if (elective2_courses_datagridview.Rows.Count > 0)
            {
                electiveCourse = 1;
                elective2_courses_label.Visible = true;
                elective2_courses_datagridview.Visible = true;
                elective2_courses_datagridview.Dock = DockStyle.Top;
            }
            else
            {
                elective2_courses_label.Visible = false;
                elective2_courses_datagridview.Visible = false;
            }

            if (elective3_courses_datagridview.Rows.Count > 0)
            {
                electiveCourse = 1;
                elective3_courses_label.Visible = true;
                elective3_courses_datagridview.Visible = true;
                elective3_courses_datagridview.Dock = DockStyle.Top;
            }
            else
            {
                elective3_courses_datagridview.Visible = false;
                elective3_courses_label.Visible = false;
            }

            if (elective4_courses_datagridview.Rows.Count > 0)
            {
                electiveCourse = 1;
                elective4_courses_label.Visible = true;
                elective4_courses_datagridview.Visible = true;
                elective4_courses_datagridview.Dock = DockStyle.Top;
            }
            else
            {
                elective4_courses_label.Visible = false;
                elective4_courses_datagridview.Visible = false;
            }


            
            elective_courses_label.Visible = (electiveCourse == 1) ? true : false;


            // Refresh the DataGridView to reflect changes
            core_courses_datagridview.Refresh();
            elective1_courses_datagridview.Refresh();
            elective2_courses_datagridview.Refresh();
            elective3_courses_datagridview.Refresh();
            elective4_courses_datagridview.Refresh();
            elective1_courses_datagridview.Refresh();

        }

        private void AdjustAllDataGridViews()
        {
            AdjustDataGridViewHeight(core_courses_datagridview);
            AdjustDataGridViewHeight(elective1_courses_datagridview);
            AdjustDataGridViewHeight(elective2_courses_datagridview);
            AdjustDataGridViewHeight(elective3_courses_datagridview);
            AdjustDataGridViewHeight(elective4_courses_datagridview);
        }
        private void AdjustDataGridViewHeight(DataGridView dataGridView)
        {
            int rowHeight = dataGridView.RowTemplate.Height;
            int headerHeight = dataGridView.ColumnHeadersHeight;
            dataGridView.Height = (dataGridView.Rows.Count * rowHeight) + headerHeight + 20;
        }

        private Control GetPreviousControl(Control currentControl)
        {
            Control previousControl = null;
            Control.ControlCollection controls = this.Controls;

            for (int i = 0; i < controls.Count; i++)
            {
                if (controls[i] == currentControl)
                {
                    if (i > 0)
                        previousControl = controls[i - 1];

                    break;
                }
            }

            return previousControl;
        }

        // Action listener perform for after department choosed
        private void department_choose_button_Click(object sender, EventArgs e)
        {
            DepartmentOption();
        }

        // Action listener perform for offered courses
        private void completed_course_button_Click(object sender, EventArgs e)
        {
            inValidFormat = false;
            outOfRange = false;
            inValidNumber = false;
            CourseDataUserInput(course_number_textbox.Text, allCourses, departmentNumber);
        }

        // To return in 
        private void back_button_Click(object sender, EventArgs e)
        {
            DepartmentEnviroment();
        }
    }
}
