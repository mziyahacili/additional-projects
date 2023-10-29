
#include <iostream>
#include <cstring>
using namespace std;

#pragma region Constructors
struct Person {
private:
    int age{};
    char* name{};
    char* surname{};
public:
    Person() = default;

    Person(char* name, char *username, int age) // Конструктор
    {
        this->name = name;
        this->surname = surname;
        this->age = age;
    }
};
#pragma endregion Constructors

// Create our class String.
class MyString{
private:
    char* str{};    // Строка
    uint16_t size{}; // Размер строки
    uint16_t capacity{16}; // Вместимость
public:
    MyString() = default;

    MyString(const char* data){
        const size_t dataLength = strlen(data);
        while (dataLength >= capacity)
        {
            capacity *= 2;  // На самом деле string в с++ работает таким образом. По степени двойки начиная с 16. Capacity у него 16, 32, 64 и так растёт(по геометрической прогрессии).
        }
        this->str = new char[capacity]{};
        this->size = dataLength;

        strcpy_s(this->str, dataLength + 1, data);
    }

    void append(const char*data)
    {
        const size_t dataLength = strlen(data);
        const size_t newLength = this->size + dataLength; // New length string

        while(newLength >= capacity)
        {
            capacity *= 2;
        }

        char *newStr = new char[capacity]{};
        strcpy_s(newStr /*Destination принимает указатель. Это указатель на начало массива*/ , this->size +1, this->str);
        strcpy_s(newStr/*Указатель массива + size. То есть в какую позицию char массива ему записывать (арифметика указателей)*/ + this->size, dataLength + 1, data);
        // strlen без \0 возвращает длину
        delete[] this->str;
        this->str = newStr;
        this->size = newLength;

    }
    void print()
    {
        cout << this->str << endl;
    }

};


int main()
{
    MyString name = "Ziya"; // Это тоже самое, что и MyString name("Ziya");  --С++ автоматически расценивает в структурах и классах '=' как то, что мы записываем в параметр.
    name.print();

    name.append(" Hacili");
    name.print();

    return 0;
}