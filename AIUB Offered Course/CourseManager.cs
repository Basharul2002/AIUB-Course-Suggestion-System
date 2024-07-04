﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_Offered_Course
{
    internal class CourseManager
    {

        // Function to handle CSE courses
        public static List<Course> CseCourses()
        {
            return new List<Course>
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

        }

        // Function to handle EEE courses
        public static List<Course> EeeCourses()
        {
            return new List<Course>
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

        }

        // Function to handle English courses
        public static List<Course> EnglishCourses()
        {
            return new List<Course>
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
                new Course { Name = "MORPHOLOGY", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 8
                new Course { Name = "HISTORY OF EMERGENCE OF BANGLADESH", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 9
                new Course { Name = "APPRECIATION OF POETRY", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 10
                new Course { Name = "FUNDAMENTALS OF ECONOMICS", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1 }, // 11
                new Course { Name = "NATURAL SCIENCE", Prerequisites = new HashSet<int> (), CourseCredit = 3, CourseType = 1}, // 12


                // Semester 3
                new Course { Name = "WRITING FOR ARTS AND SOCIAL SCIENCES", Prerequisites = new HashSet<int> {7}, CourseCredit = 3, CourseType = 1}, // 13
                new Course { Name = "BANGLADESH STUDIES", Prerequisites = new HashSet<int> {8}, CourseCredit = 3, CourseType = 1}, // 14
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

        }

        public static List<Course> BBACourses()
        {
            return new List<Course>
                                        {
                                            // Semester 1
                                            new Course { Name = "Foundation Course", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1}, // 1
                                            new Course { Name = "Introduction to Business", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1}, // 2
                                            new Course { Name = "Financial Accounting", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Business Mathematics 1", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "English Reading", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Bangladesh Studies", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1},

                                            // Semester 2
                                            new Course { Name = "Business Management", Prerequisites = new HashSet<int>{1, 2}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Principles of Marketing", Prerequisites = new HashSet<int>{2}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Business Mathematics 2", Prerequisites = new HashSet<int>{4}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "English Writing", Prerequisites = new HashSet<int>{5}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Micro Economics", Prerequisites = new HashSet<int>{4}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Introduction to Information Technology ", Prerequisites = new HashSet<int>{2}, CourseCredit = 3, CourseType = 1}, //1

                                            // Semester 3
                                            new Course { Name = "Organizational Behavior", Prerequisites = new HashSet<int>{7}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Managerial Accounting", Prerequisites = new HashSet<int>{3}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Business Statistics", Prerequisites = new HashSet<int>{9}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Basic in Social Science ", Prerequisites = new HashSet<int>{6}, CourseCredit = 3, CourseType = 1}, //1
                                            new Course { Name = "Office Management Technology ", Prerequisites = new HashSet<int>{12}, CourseCredit = 3, CourseType = 1}, //1
                                            new Course { Name = "Global Languages", Prerequisites = new HashSet<int>{10}, CourseCredit = 3, CourseType = 1},

                                            // Semester 4
                                            new Course { Name = "Principles of Finance", Prerequisites = new HashSet<int>{14}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Advanced Business Statistics", Prerequisites = new HashSet<int>{15}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Business Law", Prerequisites = new HashSet<int>{13}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Macro Economics", Prerequisites = new HashSet<int>{11}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Basics in Natural Science", Prerequisites = new HashSet<int>{9, 16}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Politics Philosophy and Public Affairs ", Prerequisites = new HashSet<int>{16}, CourseCredit = 3, CourseType = 1},
                                            
                                            // Semester 5
                                            new Course { Name = "Human Resource Management", Prerequisites = new HashSet<int>{13}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Financial Management", Prerequisites = new HashSet<int>{19}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Marketing Management", Prerequisites = new HashSet<int>{8, 22}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Operations and Supply Chain Management", Prerequisites = new HashSet<int>{15}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Management Information Systems", Prerequisites = new HashSet<int>{17}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "International Business", Prerequisites = new HashSet<int>{21}, CourseCredit = 3, CourseType = 1}, //1

                                            // Semester 6
                                            new Course { Name = "Business Research", Prerequisites = new HashSet<int>{20, 27}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Principles and Practices of Taxation", Prerequisites = new HashSet<int>{19, 21}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Ethics, Sustainability, and Communication for Development ", Prerequisites = new HashSet<int>{24}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Innovation and Entrepreneurship Development ", Prerequisites = new HashSet<int>{13}, CourseCredit = 3, CourseType = 1},

                                            // Semester 7
                                            new Course { Name = "Project Management", Prerequisites = new HashSet<int>{28, 29}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Business Communication", Prerequisites = new HashSet<int>{18, 33}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Corporate Governance and Social Responsibility", Prerequisites = new HashSet<int>{26, 33}, CourseCredit = 3, CourseType = 1},
                                           
                                            // Semester 8
                                            new Course { Name = "Strategic Management", Prerequisites = new HashSet<int>{35, 36}, CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Professional Development Course ", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1},
                                            new Course { Name = "Internship", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1}, // After Completion of 132 Cr.



                                            // Accounting (ACT) - Prerequisite: BBA 26 Financial Management (For All Elective Courses)
                                            new Course { Name = "Intermediate Accounting", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 2},
                                            new Course { Name = "Cost Accounting", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 2},
                                            new Course { Name = "Financial Statement Analysis", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 2},
                                            new Course { Name = "Accounting Information Systems", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 2},
                                            new Course { Name = "Auditing", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 2},
                                            new Course { Name = "Financial and Corporate Reporting", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 2},
                                            new Course { Name = "Advanced Cost Accounting", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 2},
                                            new Course { Name = "Advanced Financial Accounting", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 2},
                                            new Course { Name = "Strategic Management Accounting", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 2},
                                            new Course { Name = "Accounting Theory and Policy", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 2},
                                            new Course { Name = "Accounting for Specialized Institutions", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 2},
                                            new Course { Name = "Corporate Finance", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 2},

                                            // Business Analytics (BA) - Prerequisite: BBA 2117 Office Management Technology (For All Elective Courses)
                                            new Course { Name = "Analytics for Business Professionals", Prerequisites = new HashSet<int> {17}, CourseCredit = 3, CourseType = 3},
                                            new Course { Name = "Technology Adoption Theories and Models", Prerequisites = new HashSet<int> {17}, CourseCredit = 3, CourseType = 3},
                                            new Course { Name = "Visualization and Communication of Business Data", Prerequisites = new HashSet<int> {17}, CourseCredit = 3, CourseType = 3},
                                            new Course { Name = "Analytics for Sports Management", Prerequisites = new HashSet<int> {17}, CourseCredit = 3, CourseType = 3},
                                            new Course { Name = "Legal and Ethical Issues in Data Management", Prerequisites = new HashSet<int> {17}, CourseCredit = 3, CourseType = 3},
                                            new Course { Name = "Analyzing Exploratory Data in Business", Prerequisites = new HashSet<int> {17}, CourseCredit = 3, CourseType = 3},
                                            new Course { Name = "Analytics for Healthcare and Medical Industries", Prerequisites = new HashSet<int> {17}, CourseCredit = 3, CourseType = 3},
                                            new Course { Name = "Data and Web Analytics", Prerequisites = new HashSet<int> {17}, CourseCredit = 3, CourseType = 3},
                                            new Course { Name = "Financial Analytics", Prerequisites = new HashSet<int> {17}, CourseCredit = 3, CourseType = 3},
                                            new Course { Name = "Retail Analytics", Prerequisites = new HashSet<int> {17}, CourseCredit = 3, CourseType = 3},
                                            new Course { Name = "Analytics for Talent Management", Prerequisites = new HashSet<int> {17}, CourseCredit = 3, CourseType = 3},
                                            new Course { Name = "Seminar (Business Analytics)", Prerequisites = new HashSet<int> {17}, CourseCredit = 3, CourseType = 3},
                                            new Course { Name = "Capstone Project (Business Analytics)", Prerequisites = new HashSet<int> {17}, CourseCredit = 3, CourseType = 3},
                                            new Course { Name = "Database Analysis and Design", Prerequisites = new HashSet<int> {17}, CourseCredit = 3, CourseType = 3},
                                            new Course { Name = "Object Oriented Programming", Prerequisites = new HashSet<int> {17}, CourseCredit = 3, CourseType = 3},
                                            new Course { Name = "Data Warehouse and Data Mining", Prerequisites = new HashSet<int> {17}, CourseCredit = 3, CourseType = 3},
                                            new Course { Name = "Social Media and Digital Marketing", Prerequisites = new HashSet<int> {17}, CourseCredit = 3, CourseType = 3},
                                            new Course { Name = "Supply Chain Analytics", Prerequisites = new HashSet<int> {17}, CourseCredit = 3, CourseType = 3},


                                            // Business Economics (BECO) - Prerequisite: BBA 2222 Macro Economics (For All Elective Courses)
                                            new Course { Name = "Microeconomic Theory", Prerequisites = new HashSet<int> {22}, CourseCredit = 3, CourseType = 4},
                                            new Course { Name = "Macroeconomics of Developing Countries", Prerequisites = new HashSet<int> {22}, CourseCredit = 3, CourseType = 4},
                                            new Course { Name = "Mathematical Economics", Prerequisites = new HashSet<int> {22}, CourseCredit = 3, CourseType = 4},
                                            new Course { Name = "Applied Econometric Models", Prerequisites = new HashSet<int> {22}, CourseCredit = 3, CourseType = 4},
                                            new Course { Name = "Development Economics", Prerequisites = new HashSet<int> {22}, CourseCredit = 3, CourseType = 4},
                                            new Course { Name = "Political Economy", Prerequisites = new HashSet<int> {22}, CourseCredit = 3, CourseType = 4},
                                            new Course { Name = "Economics of Natural Resources and Environment", Prerequisites = new HashSet<int> {22}, CourseCredit = 3, CourseType = 4},
                                            new Course { Name = "Comparative Economic Analysis", Prerequisites = new HashSet<int> {22}, CourseCredit = 3, CourseType = 4},
                                            new Course { Name = "Bangladesh Economy", Prerequisites = new HashSet<int> {22}, CourseCredit = 3, CourseType = 4},
                                            new Course { Name = "Introduction to Game Theory", Prerequisites = new HashSet<int> {22}, CourseCredit = 3, CourseType = 4},
                                            new Course { Name = "Labor Economics", Prerequisites = new HashSet<int> {22}, CourseCredit = 3, CourseType = 4},
                                            new Course { Name = "Health Economics", Prerequisites = new HashSet<int> {22}, CourseCredit = 3, CourseType = 4},

                                            // Finance (FIN) - Prerequisite: BBA 3126 Financial Management (For All Elective Courses)
                                            new Course { Name = "Corporate Finance", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 5},
                                            new Course { Name = "Financial Institutions and Markets", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 5},
                                            new Course { Name = "Investment Analysis and Portfolio Management", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 5},
                                            new Course { Name = "Capital Budgeting", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 5},
                                            new Course { Name = "Bank Fund Management", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 5},
                                            new Course { Name = "Working Capital Management", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 5},
                                            new Course { Name = "Islamic Finance and Banking", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 5},
                                            new Course { Name = "Global Finance", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 5},
                                            new Course { Name = "Financial Derivatives", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 5},
                                            new Course { Name = "Comprehensive Financial Case Analysis", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 5},
                                            new Course { Name = "Financial Statement Analysis", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 5},

                                            // Human Resource Management (HRM) - Prerequisite: BBA 3125 Human Resource Management (For All Elective Courses)
                                            new Course { Name = "Human Resource Planning and Forecasting", Prerequisites = new HashSet<int> {25}, CourseCredit = 3, CourseType = 6},
                                            new Course { Name = "Performance Appraisal and Management", Prerequisites = new HashSet<int> {25}, CourseCredit = 3, CourseType = 6},
                                            new Course { Name = "Selection and Staffing", Prerequisites = new HashSet<int> {25}, CourseCredit = 3, CourseType = 6},
                                            new Course { Name = "Training and Development", Prerequisites = new HashSet<int> {25}, CourseCredit = 3, CourseType = 6},
                                            new Course { Name = "Labor Law of Bangladesh", Prerequisites = new HashSet<int> {25}, CourseCredit = 3, CourseType = 6},
                                            new Course { Name = "Compensation and Benefit Management", Prerequisites = new HashSet<int> {25}, CourseCredit = 3, CourseType = 6},
                                            new Course { Name = "Industrial Relations Management", Prerequisites = new HashSet<int> {25}, CourseCredit = 3, CourseType = 6},
                                            new Course { Name = "Human Resource Information System (HRIS)", Prerequisites = new HashSet<int> {25}, CourseCredit = 3, CourseType = 6},
                                            new Course { Name = "Human Resource in Global Business Environment", Prerequisites = new HashSet<int> {25}, CourseCredit = 3, CourseType = 6},
                                            new Course { Name = "Occupational Health and Safety Management", Prerequisites = new HashSet<int> {25}, CourseCredit = 3, CourseType = 6},
                                            new Course { Name = "Organizational Theory and Development", Prerequisites = new HashSet<int> {25}, CourseCredit = 3, CourseType = 6},
                                            new Course { Name = "Strategic Human Resource Management", Prerequisites = new HashSet<int> {25}, CourseCredit = 3, CourseType = 6},

                                            // Innovation and Entrepreneurship Development (IED) - Prerequisite: BBA 3234 Innovation and Entrepreneurship Development (For All Elective Courses)
                                            new Course { Name = "Entrepreneurial Mindset and Behavior", Prerequisites = new HashSet<int> {34}, CourseCredit = 3, CourseType = 7},
                                            new Course { Name = "Accounting for Entrepreneurs", Prerequisites = new HashSet<int> {34}, CourseCredit = 3, CourseType = 7},
                                            new Course { Name = "New Venture Development", Prerequisites = new HashSet<int> {34}, CourseCredit = 3, CourseType = 7},
                                            new Course { Name = "Entrepreneurial Finance", Prerequisites = new HashSet<int> {34}, CourseCredit = 3, CourseType = 7},
                                            new Course { Name = "Economics for the Entrepreneurs", Prerequisites = new HashSet<int> {34}, CourseCredit = 3, CourseType = 7},
                                            new Course { Name = "Consumer Behavior and Digital Marketing", Prerequisites = new HashSet<int> {34}, CourseCredit = 3, CourseType = 7},
                                            new Course { Name = "E-commerce", Prerequisites = new HashSet<int> {34}, CourseCredit = 3, CourseType = 7},
                                            new Course { Name = "Marketing Research for Entrepreneurs", Prerequisites = new HashSet<int> {34}, CourseCredit = 3, CourseType = 7},
                                            new Course { Name = "Business Risk Management", Prerequisites = new HashSet<int> {34}, CourseCredit = 3, CourseType = 7},
                                            new Course { Name = "Enterprise Resource Planning", Prerequisites = new HashSet<int> {34}, CourseCredit = 3, CourseType = 7},
                                            new Course { Name = "Business Intelligence and Decision Support System", Prerequisites = new HashSet<int> {34}, CourseCredit = 3, CourseType = 7},

                                            // International Business (IB) - Prerequisite: BBA 3130 International Business (For All Elective Courses)
                                            new Course { Name = "International Banking", Prerequisites = new HashSet<int> {30}, CourseCredit = 3, CourseType = 8},
                                            new Course { Name = "Global Business Strategy", Prerequisites = new HashSet<int> {30}, CourseCredit = 3, CourseType = 8},
                                            new Course { Name = "International Enterprises and Transactions", Prerequisites = new HashSet<int> {30}, CourseCredit = 3, CourseType = 8},
                                            new Course { Name = "International Business Governance, Ethics and Law", Prerequisites = new HashSet<int> {30}, CourseCredit = 3, CourseType = 8},
                                            new Course { Name = "Development Economics", Prerequisites = new HashSet<int> {30}, CourseCredit = 3, CourseType = 8},
                                            new Course { Name = "Labor Economics", Prerequisites = new HashSet<int> {30}, CourseCredit = 3, CourseType = 8},
                                            new Course { Name = "Global Finance", Prerequisites = new HashSet<int> {30}, CourseCredit = 3, CourseType = 8},
                                            new Course { Name = "Human Resource in Global Business Environment", Prerequisites = new HashSet<int> {30}, CourseCredit = 3, CourseType = 8},
                                            new Course { Name = "Negotiation Theory and Practice", Prerequisites = new HashSet<int> {30}, CourseCredit = 3, CourseType = 8},
                                            new Course { Name = "Enterprise Resource Planning", Prerequisites = new HashSet<int> {30}, CourseCredit = 3, CourseType = 8},
                                            new Course { Name = "International Marketing", Prerequisites = new HashSet<int> {30}, CourseCredit = 3, CourseType = 8},
                                            new Course { Name = "Logistics Management", Prerequisites = new HashSet<int> {30}, CourseCredit = 3, CourseType = 8},

                                            // Investment Management (IM) - Prerequisite: BBA 3126 Financial Management (For All Elective Courses)
                                            new Course { Name = "Regulations and Investment", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 9},
                                            new Course { Name = "Doing Business in Bangladesh", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 9},
                                            new Course { Name = "Macroeconomic Conditions for Investment", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 9},
                                            new Course { Name = "Economics and Law", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 9},
                                            new Course { Name = "Business Risk Management", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 9},
                                            new Course { Name = "Development Economics", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 9},
                                            new Course { Name = "Labor Economics", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 9},
                                            new Course { Name = "Financial Institutions and Markets", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 9},
                                            new Course { Name = "Investment Analysis and Portfolio Management", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 9},
                                            new Course { Name = "Global Finance", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 9},
                                            new Course { Name = "Financial Derivatives", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 9},
                                            new Course { Name = "Agri-business Management", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 9},
                                            new Course { Name = "Negotiation Theory and Practice", Prerequisites = new HashSet<int> {26}, CourseCredit = 3, CourseType = 9},

                                            // Management (MGT)
                                            new Course { Name = "Management of Change and Technology", Prerequisites = new HashSet<int> { 13 }, CourseCredit = 3, CourseType = 10},
                                            new Course { Name = "Public Sector Management", Prerequisites = new HashSet<int> { 13 }, CourseCredit = 3, CourseType = 10},
                                            new Course { Name = "Environment Management", Prerequisites = new HashSet<int> { 13 }, CourseCredit = 3, CourseType = 10},
                                            new Course { Name = "Managing of NGOs and Small Business", Prerequisites = new HashSet<int> { 13 }, CourseCredit = 3, CourseType = 10},
                                            new Course { Name = "Cooperative Management", Prerequisites = new HashSet<int> { 13 }, CourseCredit = 3, CourseType = 10},
                                            new Course { Name = "Disaster Management", Prerequisites = new HashSet<int> { 13 }, CourseCredit = 3, CourseType = 10},
                                            new Course { Name = "Agri-business Management", Prerequisites = new HashSet<int> { 13 }, CourseCredit = 3, CourseType = 10},
                                            new Course { Name = "Negotiation Theory and Practice", Prerequisites = new HashSet<int> { 13 }, CourseCredit = 3, CourseType = 10},
                                            new Course { Name = "Labor Law of Bangladesh", Prerequisites = new HashSet<int> { 13 }, CourseCredit = 3, CourseType = 10},
                                            new Course { Name = "Industrial Relations Management", Prerequisites = new HashSet<int> { 13 }, CourseCredit = 3, CourseType = 10},
                                            new Course { Name = "Occupational Health and Safety Management", Prerequisites = new HashSet<int> { 13 }, CourseCredit = 3, CourseType = 10},
                                            new Course { Name = "Organization Theory and Development", Prerequisites = new HashSet<int> { 13 }, CourseCredit = 3, CourseType = 10},
                                            new Course { Name = "Global Business Strategy", Prerequisites = new HashSet<int> { 13 }, CourseCredit = 3, CourseType = 10},
                                            new Course { Name = "Inventory Management", Prerequisites = new HashSet<int> { 13 }, CourseCredit = 3, CourseType = 10},
                                            new Course { Name = "Hospitality Management", Prerequisites = new HashSet<int> { 13 }, CourseCredit = 3, CourseType = 10},


                                            // Management Information Systems (MIS)
                                            new Course { Name = "Enterprise Resource Planning", Prerequisites = new HashSet<int> { 29 }, CourseCredit = 3, CourseType = 11},
                                            new Course { Name = "Database Analysis and Design", Prerequisites = new HashSet<int> { 29 }, CourseCredit = 3, CourseType = 11},
                                            new Course { Name = "Object Oriented Programming", Prerequisites = new HashSet<int> { 29 }, CourseCredit = 3, CourseType = 11},
                                            new Course { Name = "Digital Marketing", Prerequisites = new HashSet<int> { 29 }, CourseCredit = 3, CourseType = 11},
                                            new Course { Name = "Data Warehouse and Data Mining", Prerequisites = new HashSet<int> { 29 }, CourseCredit = 3, CourseType = 11},
                                            new Course { Name = "Business Intelligence and Decision Support System", Prerequisites = new HashSet<int> { 29 }, CourseCredit = 3, CourseType = 11},
                                            new Course { Name = "Special Topic in MIS", Prerequisites = new HashSet<int> { 29 }, CourseCredit = 3, CourseType = 11},
                                            new Course { Name = "Web Technology", Prerequisites = new HashSet<int> { 29 }, CourseCredit = 3, CourseType = 11},
                                            new Course { Name = "Business Graphics and Animation", Prerequisites = new HashSet<int> { 29 }, CourseCredit = 3, CourseType = 11},
                                            new Course { Name = "Network Resource Management", Prerequisites = new HashSet<int> { 29 }, CourseCredit = 3, CourseType = 11},
                                            new Course { Name = "E-Commerce and E-Governance", Prerequisites = new HashSet<int> { 29 }, CourseCredit = 3, CourseType = 11},
                                            new Course { Name = "Introduction to Data Science", Prerequisites = new HashSet<int> { 29 }, CourseCredit = 3, CourseType = 11},
                                            new Course { Name = "Cyber Security", Prerequisites = new HashSet<int> { 29 }, CourseCredit = 3, CourseType = 11},
                                            new Course { Name = "Blockchain Technologies in Business", Prerequisites = new HashSet<int> { 29 }, CourseCredit = 3, CourseType = 11},


                                            // MKT
                                            new Course { Name = "Consumer Behavior", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 12},
                                            new Course { Name = "Integrated Marketing Communication", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 12},
                                            new Course { Name = "Social Media and Digital Marketing", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 12},
                                            new Course { Name = "Services Marketing", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 12},
                                            new Course { Name = "Sales Management", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 12},
                                            new Course { Name = "International Marketing", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 12},
                                            new Course { Name = "Distribution and Channel Management", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 12},
                                            new Course { Name = "Brand and Product Management", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 12},
                                            new Course { Name = "Rural Marketing", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 12},
                                            new Course { Name = "Agro-based Product Marketing", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 12},
                                            new Course { Name = "Marketing Strategy", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 12},
                                            new Course { Name = "Marketing Research", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 12},
                                            new Course { Name = "Product Innovation and Management", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 12},
                                            new Course { Name = "Tourism and Hospitality Marketing", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 12},


                                            // Tourism and Hospitality Management (THM)
                                            new Course { Name = "Introduction to Tourism and Hospitality Industry", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 13},
                                            new Course { Name = "Tourism and Hospitality Marketing", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 13},
                                            new Course { Name = "Housekeeping Management", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 13},
                                            new Course { Name = "Recreation Management", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 13},
                                            new Course { Name = "Tourism and Hospitality Law", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 13},
                                            new Course { Name = "Travel Agency and Tour Operation Management", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 13},
                                            new Course { Name = "Event and MICE (Meeting, Incentives, Convention and Exhibitions) Management", Prerequisites = new HashSet<int> { 23 }, CourseCredit = 3, CourseType = 13},
                                            new Course { Name = "Airline Reservation and Ticketing", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 13},
                                            new Course { Name = "Food and Beverage Service Management", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 13},
                                            new Course { Name = "Destination Planning and Development", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 13},
                                            new Course { Name = "Hospitality Management", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 13},
                                            new Course { Name = "Consumer Behavior", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 13},
                                            new Course { Name = "Services Marketing", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 13},
                                            new Course { Name = "Marketing Strategy", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 13},
                                            new Course { Name = "Marketing Research", Prerequisites = new HashSet<int> { 27 }, CourseCredit = 3, CourseType = 13},


                                            // Operations and Supply Chain Management (OSCM)
                                            new Course { Name = "Advanced Supply Chain Management", Prerequisites = new HashSet<int> { 28 }, CourseCredit = 3, CourseType = 14},
                                            new Course { Name = "Inventory Management", Prerequisites = new HashSet<int> { 28 }, CourseCredit = 3, CourseType = 14},
                                            new Course { Name = "Sourcing and Negotiation", Prerequisites = new HashSet<int> { 28 }, CourseCredit = 3, CourseType = 14},
                                            new Course { Name = "Logistics Management", Prerequisites = new HashSet<int> { 28 }, CourseCredit = 3, CourseType = 14},
                                            new Course { Name = "Managerial Forecasting", Prerequisites = new HashSet<int> { 28 }, CourseCredit = 3, CourseType = 14},
                                            new Course { Name = "Purchasing and Procurement", Prerequisites = new HashSet<int> { 28 }, CourseCredit = 3, CourseType = 14},
                                            new Course { Name = "Supply Chain Analytics", Prerequisites = new HashSet<int> { 28 }, CourseCredit = 3, CourseType = 14},
                                            new Course { Name = "Service Operations Management", Prerequisites = new HashSet<int> { 28 }, CourseCredit = 3, CourseType = 14},
                                            new Course { Name = "Total Quality Management", Prerequisites = new HashSet<int> { 28 }, CourseCredit = 3, CourseType = 14},
                                            new Course { Name = "Product Strategy Management", Prerequisites = new HashSet<int> { 28 }, CourseCredit = 3, CourseType = 14},
                                            new Course { Name = "Enterprise Resource Planning", Prerequisites = new HashSet<int> { 28 }, CourseCredit = 3, CourseType = 14},
                                            new Course { Name = "Blockchain Technologies in Business", Prerequisites = new HashSet<int> { 28 }, CourseCredit = 3, CourseType = 14},

            };
        }

        public static List<Course> IPECourses()
        {
            return new List<Course>
    {
        // Semester 1
        new Course { Name = "INTRODUCTION TO ENGINEERING STUDIES", Prerequisites = new HashSet<int>(), CourseCredit = 1, CourseType = 1}, // 1
        new Course { Name = "CHEMISTRY", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1}, // 2
        new Course { Name = "PHYSICS 1", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1}, // 3
        new Course { Name = "PHYSICS 1 LAB", Prerequisites = new HashSet<int>(), CourseCredit = 1, CourseType = 1}, // 4
        new Course { Name = "ENGINEERING DRAWING", Prerequisites = new HashSet<int>(), CourseCredit = 1, CourseType = 1}, // 5
        new Course { Name = "DIFFERENTIAL CALCULUS AND COORDINATE GEOMETRY", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1}, // 6
        new Course { Name = "ENGLISH READING SKILLS & PUBLIC SPEAKING", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1}, // 7
        new Course { Name = "BANGLADESH STUDIES", Prerequisites = new HashSet<int>(), CourseCredit = 3, CourseType = 1}, // 8
        new Course { Name = "MACHINE JOB SHOP- I (DRILLING, WELDING, MILLING AND TURNING)", Prerequisites = new HashSet<int>(), CourseCredit = 1, CourseType = 1}, // 9


        // Semester 2
        new Course { Name = "ENGINEERING MATERIALS", Prerequisites = new HashSet<int> { 9 }, CourseCredit = 3, CourseType = 1}, // 10
        new Course { Name = "ENGINEERING MATERIALS LAB", Prerequisites = new HashSet<int> { 9 }, CourseCredit = 1, CourseType = 1}, // 11
        new Course { Name = "ENGINEERING MECHANICS", Prerequisites = new HashSet<int> { 6 }, CourseCredit = 3, CourseType = 1}, // 12
        new Course { Name = "ENGINEERING MECHANICS LAB", Prerequisites = new HashSet<int> { 6 }, CourseCredit = 1, CourseType = 1}, // 13
        new Course { Name = "ENGLISH WRITING SKILLS & COMMUNICATIONS", Prerequisites = new HashSet<int> { 7 }, CourseCredit = 3, CourseType = 1}, // 14
        new Course { Name = "INTEGRAL CALCULUS & ORDINARY DIFFERENTIAL EQUATION", Prerequisites = new HashSet<int> { 6 }, CourseCredit = 3, CourseType = 1}, // 15
        new Course { Name = "BASIC MECHANICAL ENGINEERING", Prerequisites = new HashSet<int> { 1 }, CourseCredit = 3, CourseType = 1}, // 16
        new Course { Name = "COMPUTER AIDED DRAWING", Prerequisites = new HashSet<int> { 5 }, CourseCredit = 1, CourseType = 1}, // 17
        new Course { Name = "MACHINE JOB SHOP- II (SHEET METAL FORMING AND CASTING)", Prerequisites = new HashSet<int> { 9 }, CourseCredit = 1, CourseType = 1}, // 18


        // Semester 3
        new Course { Name = "INTRODUCTION TO ELECTRICAL CIRCUITS", Prerequisites = new HashSet<int> { 3 }, CourseCredit = 3, CourseType = 1}, // 19
        new Course { Name = "INTRODUCTION TO ELECTRICAL CIRCUITS LAB", Prerequisites = new HashSet<int> { 4 }, CourseCredit = 1, CourseType = 1}, // 20
        new Course { Name = "COMPLEX VARIABLE, LAPLACE & Z-TRANSFORMATION", Prerequisites = new HashSet<int> { 6 }, CourseCredit = 3, CourseType = 1}, // 21
        new Course { Name = "PHYSICS 2", Prerequisites = new HashSet<int> { 3 }, CourseCredit = 3, CourseType = 1}, // 22
        new Course { Name = "PHYSICS 2 LAB", Prerequisites = new HashSet<int> { 4 }, CourseCredit = 1, CourseType = 1}, // 23
        new Course { Name = "PRINCIPLES OF ACCOUNTING [IPE]", Prerequisites = new HashSet<int> { 15 }, CourseCredit = 2, CourseType = 1}, // 24
        new Course { Name = "MECHANICS OF SOLIDS", Prerequisites = new HashSet<int> { 12 }, CourseCredit = 3, CourseType = 1}, // 25
        new Course { Name = "MECHANICS OF SOLIDS LAB", Prerequisites = new HashSet<int> { 13 }, CourseCredit = 1, CourseType = 1}, // 26
        new Course { Name = "PROGRAMMING LANGUAGE 1 (STRUCTURED PROGRAMMING LANGUAGE)", Prerequisites = new HashSet<int> { 15 }, CourseCredit = 3, CourseType = 1}, // 27


        // Semeseter 4
        new Course { Name = "MANUFACTURING AND PRODUCTION PROCESS I", Prerequisites = new HashSet<int> { 18 }, CourseCredit = 3, CourseType = 1}, // 28
        new Course { Name = "MANUFACTURING AND PRODUCTION PROCESS I LAB", Prerequisites = new HashSet<int> { 18 }, CourseCredit = 1, CourseType = 1}, // 29
        new Course { Name = "STATISTICAL DECISION MAKING FOR ENGINEERS", Prerequisites = new HashSet<int> { 21 }, CourseCredit = 3, CourseType = 1}, // 30
        new Course { Name = "MATRICES, VECTORS, FOURIER ANALYSIS", Prerequisites = new HashSet<int> { 21 }, CourseCredit = 3, CourseType = 1}, // 31
        new Course { Name = "MACHINE TOOLS", Prerequisites = new HashSet<int> { 18 }, CourseCredit = 3, CourseType = 1}, // 32
        new Course { Name = "MACHINE TOOLS LAB", Prerequisites = new HashSet<int> { 18 }, CourseCredit = 1, CourseType = 1}, // 33
        new Course { Name = "PRINCIPLES OF ECONOMICS", Prerequisites = new HashSet<int> { 24 }, CourseCredit = 2, CourseType = 1}, // 34
        new Course { Name = "FLUID MECHANICS AND MACHINERY", Prerequisites = new HashSet<int> { 16 }, CourseCredit = 3, CourseType = 1}, // 35
        new Course { Name = "FLUID MECHANICS AND MACHINERY LAB", Prerequisites = new HashSet<int> { 16 }, CourseCredit = 1, CourseType = 1}, // 36

        // Semester 5
        new Course { Name = "NUMERICAL METHODS FOR SCIENCE AND ENGINEERING", Prerequisites = new HashSet<int> { 31 }, CourseCredit = 3, CourseType = 1}, // 37
        new Course { Name = "TECH ELECTIVE 1", Prerequisites = new HashSet<int> { 30 }, CourseCredit = 3, CourseType = 1}, // 37
        new Course { Name = "LOGISTICS AND DISTRIBUTION MANAGEMENT", Prerequisites = new HashSet<int> { 24 }, CourseCredit = 3, CourseType = 1}, // 38
        new Course { Name = "PRODUCT DESIGN AND DEVELOPMENT", Prerequisites = new HashSet<int> { 30 }, CourseCredit = 3, CourseType = 1}, // 39
        new Course { Name = "MANUFACTURING AND PRODUCTION PROCESS II", Prerequisites = new HashSet<int> { 28 }, CourseCredit = 3, CourseType = 1}, // 40
        new Course { Name = "COMPUTER INTEGRATED MANUFACTURING", Prerequisites = new HashSet<int> { 17 }, CourseCredit = 3, CourseType = 1}, // 41
        new Course { Name = "ENGINEERING ECONOMY [IPE]", Prerequisites = new HashSet<int> { 24 }, CourseCredit = 3, CourseType = 1}, // 42


        // Semseter 6
        new Course { Name = "BUSINESS COMMUNICATION", Prerequisites = new HashSet<int> { 13 }, CourseCredit = 3, CourseType = 1}, // 43
        new Course { Name = "TECH ELECTIVE 2", Prerequisites = new HashSet<int> { 42 }, CourseCredit = 3, CourseType = 1}, // 44
        new Course { Name = "OPERATIONS MANAGEMENT [IPE]", Prerequisites = new HashSet<int> { 38 }, CourseCredit = 3, CourseType = 1}, // 45
        new Course { Name = "OPERATIONS RESEARCH [IPE]", Prerequisites = new HashSet<int> { 38 }, CourseCredit = 3, CourseType = 1}, // 46
        new Course { Name = "QUALITY MANAGEMENT", Prerequisites = new HashSet<int> { 38 }, CourseCredit = 3, CourseType = 1}, // 47
        new Course { Name = "PROJECT MANAGEMENT [IPE]", Prerequisites = new HashSet<int> { 38 }, CourseCredit = 3, CourseType = 1}, // 48


        // Semseter 7
        new Course { Name = "MODERN CONTROL SYSTEMS", Prerequisites = new HashSet<int> { 4 }, CourseCredit = 3, CourseType = 1}, // 49
        new Course { Name = "MODERN CONTROL SYSTEMS LAB", Prerequisites = new HashSet<int> { 4 }, CourseCredit = 1, CourseType = 1}, // 50
        new Course { Name = "SUPPLY CHAIN MANAGEMENT [IPE]", Prerequisites = new HashSet<int> { 3 }, CourseCredit = 3, CourseType = 1}, // 51
        new Course { Name = "TECH ELECTIVE 3", Prerequisites = new HashSet<int> { 6 }, CourseCredit = 3, CourseType = 1}, // 52
        new Course { Name = "DESIGN AND SIMULATION IN IE", Prerequisites = new HashSet<int> { 5 }, CourseCredit = 3, CourseType = 1}, // 53
        new Course { Name = "DESIGN AND SIMULATION IN IE LAB", Prerequisites = new HashSet<int> { 5 }, CourseCredit = 1, CourseType = 1}, // 54
        new Course { Name = "ENGINEERING ETHICS AND ENVIRONMENTAL PROTECTION", Prerequisites = new HashSet<int> { 6 }, CourseCredit = 1, CourseType = 1}, // 55


        // Semseter 8
        new Course { Name = "CAPSTONE PROJECT [IPE]", Prerequisites = new HashSet<int> { 6 }, CourseCredit = 3, CourseType = 1}, // 56
        new Course { Name = "TECH ELECTIVE 4", Prerequisites = new HashSet<int> { 7 }, CourseCredit = 3, CourseType = 1}, // 57
        new Course { Name = "INDUSTRIAL ERGONOMICS AND OCCUPATIONAL SAFETY", Prerequisites = new HashSet<int> { 5 }, CourseCredit = 3, CourseType = 1}, // 57
        new Course { Name = "MAINTENANCE MANAGEMENT", Prerequisites = new HashSet<int> { 5 }, CourseCredit = 3, CourseType = 1}, // 58
        new Course { Name = "VALUE CHAIN MANAGEMENT", Prerequisites = new HashSet<int> { 3 }, CourseCredit = 3, CourseType = 1}, // 59
        new Course { Name = "INDUSTRIAL TRAINING / INTERNSHIP", Prerequisites = new HashSet<int> { 4 }, CourseCredit = 1, CourseType = 1}, // 59


        // Elective Courses
        // MAJOR IN INDUSTRIAL ENGINEERING
        new Course { Name = "ENGINEERING MANAGEMENT [IPE]", Prerequisites = new HashSet<int> { 6 }, CourseCredit = 3, CourseType = 2}, // 60
        new Course { Name = "HUMAN FACTORS ENGINEERING", Prerequisites = new HashSet<int> { 3 }, CourseCredit = 3, CourseType = 2}, // 61
        new Course { Name = "OCCUPATIONAL ERGONOMICS", Prerequisites = new HashSet<int> { 5 }, CourseCredit = 3, CourseType = 2}, // 62
        new Course { Name = "MANAGERIAL COMMUNICATION FOR ENGINEERS", Prerequisites = new HashSet<int> { 6 }, CourseCredit = 3, CourseType = 2}, // 63
        new Course { Name = "FACILITY DESIGN AND MATERIAL HANDLING", Prerequisites = new HashSet<int> { 5 }, CourseCredit = 3, CourseType = 2}, // 64
        new Course { Name = "MARKETING MANAGEMENT [IPE]", Prerequisites = new HashSet<int> { 4 }, CourseCredit = 3, CourseType = 2}, // 65
        new Course { Name = "MANAGEMENT OF TECHNOLOGY [IPE]", Prerequisites = new HashSet<int> { 7 }, CourseCredit = 3, CourseType = 2}, // 66


        // MAJOR IN SYSTEM ENGINEERING
        new Course { Name = "PRODUCTION SYSTEMS PLANNING", Prerequisites = new HashSet<int> { 5 }, CourseCredit = 3, CourseType = 3}, // 67
        new Course { Name = "AUTOMATED SYSTEM ENGINEERING", Prerequisites = new HashSet<int> { 6 }, CourseCredit = 3, CourseType = 3}, // 68
        new Course { Name = "DESIGN AND ANALYSIS OF INDUSTRIAL SYSTEMS WITH SIMULATION", Prerequisites = new HashSet<int> { 5 }, CourseCredit = 3, CourseType = 3}, // 69
        new Course { Name = "PRINCIPLES OF PROGRAMMABLE AUTOMATION", Prerequisites = new HashSet<int> { 1 }, CourseCredit = 3, CourseType = 3}, // 70
        new Course { Name = "MANUFACTURING SYSTEMS DESIGN", Prerequisites = new HashSet<int> { 7 }, CourseCredit = 3, CourseType = 3}, // 71
        new Course { Name = "ENGINEERING DATABASE DESIGN", Prerequisites = new HashSet<int> { 3 }, CourseCredit = 3, CourseType = 3}, // 72
        new Course { Name = "IE SYSTEMS DESIGN", Prerequisites = new HashSet<int> { 8 }, CourseCredit = 3, CourseType = 3}, // 73


        // MAJOR IN PRODUCTION ENGINEERING
        new Course { Name = "MODERN MANUFACTURING TECHNOLOGY", Prerequisites = new HashSet<int> { 17 }, CourseCredit = 3, CourseType = 4}, // 74
        new Course { Name = "METAL CUTTING PROCESS", Prerequisites = new HashSet<int> { 15 }, CourseCredit = 3, CourseType = 4}, // 75
        new Course { Name = "MECHATRONICS ENGINEERING", Prerequisites = new HashSet<int> { 18 }, CourseCredit = 3, CourseType = 4}, // 76
        new Course { Name = "PRODUCTION PLANNING & PROCESS CONTROL", Prerequisites = new HashSet<int> { 19 }, CourseCredit = 3, CourseType = 4}, // 77
        new Course { Name = "MICRO MANUFACTURING", Prerequisites = new HashSet<int> { 17 }, CourseCredit = 3, CourseType = 4}, // 78
        new Course { Name = "GREEN TECHNOLOGY", Prerequisites = new HashSet<int> { 2 }, CourseCredit = 3, CourseType = 4}, // 79
        new Course { Name = "ADVANCE MATERIAL AND PROCESS", Prerequisites = new HashSet<int> { 17 }, CourseCredit = 3, CourseType = 4}, // 80
    };
        }


    }
}
