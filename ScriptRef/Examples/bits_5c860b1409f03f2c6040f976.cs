#include <stdio.h>
 
int all_bits_one(int);
int count = 0;
 
void main()
{
    int num;
    printf("enter the number:");
    scanf("%d", &num);
    num++;
    all_bits_one(num);
    if (count)
    {
        printf("false");
    }
    else
    {
        printf("true");
    }
}