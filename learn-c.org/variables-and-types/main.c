#include <stdio.h>

#define bool int
#define true 1
#define false 0

void defineBool()
{
    bool status = true;

    if (status)
    {
        printf("Status is true\n");
    }
    else
    {
        printf("Status is false\n");
    }
}

int main()
{
    defineBool();

    /*
        %c is used to print character values.
        %d is used to print integer values.
        %f is used to print float and double values.
        %s is used to print string values.
    */

    int a = 3;
    float b = 4.5;
    double c = 5.25;
    float sum;

    sum = a + b + c;
    printf("Sum of a, b and c is %f\n", sum);

    char ch = 'A';
    printf("Character is %c\n", ch);

    char str[] = "Hello, World!";
    printf("String is %s\n", str);

    return 0;
}
