#include <stdio.h>

int main()
{
    int grades[3];

    grades[0] = 80;
    grades[1] = 85;
    grades[2] = 90;

    printf("Grade 1: %d\n", grades[0]);
    printf("Grade 2: %d\n", grades[1]);
    printf("Grade 3: %d\n", grades[2]);

    // Print the memory address of the array.
    printf("Grades: %p\n", grades);

    // Print the memory address of the first element of the array.
    printf("Grade 1: %p\n", &grades[0]);

    // Print the memory address of the second element of the array.
    printf("Grade 2: %p\n", &grades[1]);

    // Print the memory address of the third element of the array.
    printf("Grade 3: %p\n", &grades[2]);

    int average = (grades[0] + grades[1] + grades[2]) / 3;

    printf("Average: %d\n", average);

    // Print the address of the average variable.
    printf("Average: %p\n", &average);

    return 0;
}
