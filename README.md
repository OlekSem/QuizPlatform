# QuizPlatform
![License|78](https://img.shields.io/badge/license-MIT-green) ![Version|90](https://img.shields.io/badge/version-1.0.0-blue)
![Language](https://img.shields.io/badge/language-C%23-yellow) ![Framework](https://img.shields.io/badge/framework-ASP.NET-orange) 

---
## Table of Contents

- [Project Information](#project-information)  
- [Project Overview](#project-overview)  
- [Objectives](#objectives)  
- [Features](#features)  
- [Technologies Used](#technologies-used)  
- [System Architecture](#system-architecture)  
- [Deployment](#deployment)  
- [Team](#team)  
- [Conclusion](#conclusion)

---
## ℹ Project Information

- **Live Demo:** [quizzy.itstep.click](https://quizzy.itstep.click)
- **Repository:** [github.com/OlekSem/QuizPlatform](https://github.com/OlekSem/QuizPlatform)
---
## Project Overview

QuizPlatform is a full-stack web application developed to support the creation, management, and completion of quizzes in an educational environment.  

The system enables teachers to design and manage quizzes, while students can take quizzes and track their performance. The platform provides a structured and interactive approach to knowledge assessment.

---

## Objectives

- Develop a web-based system for quiz management  
- Implement role-based access for different types of users  
- Provide tools for performance tracking and evaluation  
- Ensure scalability and maintainability through modern technologies  

---

## Features

### Quiz Management
- Creation of customizable quizzes with multiple question types  
- Editing and organization of quiz content  
- Reuse of previously created quizzes  

### Quiz Participation
- Interactive quiz-taking interface  
- Access to available quizzes  
- Immediate feedback after submission  

### Results and Analysis
- Storage and tracking of quiz results  
- Performance evaluation for each user  
- Basic analytical insights into quiz outcomes  

### 👥 User Authentication and Roles
- Secure authentication system  
- Role-based access:
  - **Students** – complete quizzes and view results  
  - **Teachers** – create and manage quizzes  

---

## Technologies Used

- **Framework:** ASP.NET Core MVC  
- **Language:** C#  
- **Database:** PostgreSQL  
- **Containerization:** Docker  
- **Deployment Environment:** AWS Virtual Machine (Ubuntu)  

---

## System Architecture

The application follows a full-stack architecture using ASP.NET Core MVC, where both frontend and backend logic are integrated within a single framework.

The system is containerized using Docker:
- The application runs in a dedicated container  
- PostgreSQL database runs in a separate container  

This approach ensures environment consistency, easier deployment, and scalability.

---

## Deployment

The application is deployed on an AWS virtual machine running Ubuntu.

- Docker is used to manage containers  
- The application and database are deployed as separate services  
- The system is accessible via a public domain  

---

## Team

This project was developed by a team of three:

- **Oleksandr Semeniuk** – Full-stack development (system architecture design, database design and integration, and implementation of core application features)   
- **Yurii Tereshkovych** – Full-stack development and DevOps (frontend implementation, backend contributions, Docker containerization, and deployment on AWS)   
- **Vladyslav Ostapchuk** – Full-stack development (backend logic implementation and participation in frontend development)

---

## Conclusion

The project demonstrates the development of a full-stack web application with role-based functionality, database integration, and cloud deployment.  

It highlights practical skills in backend development, system design, containerization, and deployment in a real-world environment.
