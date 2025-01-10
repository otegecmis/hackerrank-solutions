/*
   URL: https://www.hackerrank.com/challenges/functions-in-c
   Author: @otegecmis
*/

#include <stdio.h>

int max_of_four(int a, int b, int c, int d)
{
    int list[] = {a, b, c, d};
    int length = sizeof(list) / sizeof(list[0]);

    int temp = list[0];

    for (int i = 1; i < length; i++)
    {
        if (list[i] > temp)
        {
            temp = list[i];
        }
    }

    return temp;
}

int main()
{
    int a, b, c, d;
    scanf("%d %d %d %d", &a, &b, &c, &d);
    int ans = max_of_four(a, b, c, d);
    printf("%d", ans);

    return 0;
}
