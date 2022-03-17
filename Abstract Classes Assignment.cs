#include <iostream>
using namespace std;

// Abstract class
class Person {
    public:
    string firstName;
    string lastName;

    // pure virtual Function
    virtual void SayName() = 0;
};

// Derived class
class Employee : public Person {
   public:
    void SayName() {
        cout << firstName << endl;
        cout << lastName << endl;
    }
};

int main() {
    // Create object of the Employee class
    Employee emp;

    emp.firstName = "Sample";
    emp.lastName = "Student";

    // Calling method
    emp.SayName();

    return 0;
}