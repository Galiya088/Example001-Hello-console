﻿int Max(int arg1, int arg2, int arg3)

{
int result = arg1;
if(arg2> result) result = arg2;
if(arg3> result) result = arg3;
return result;

}

int [] array = {11,21,31,41,15,211,17,18,19};
int result = Max(
 Max(array[0], array[1], array[2]),
 Max(array[3], array[4], array[5]),
 Max(array[6], array[7], array[8])
 );

 Console.WriteLine(result);


/*int a1 = 15000;
int b1 = 16;
int c1 = 22;
int a2 = 23;
int b2 = 333;
int c2 = 24;
int a3 = 2311;
int b3 = 41;
int c3 = 27;*/

/*int max1 = Max(a1, b1,c1);
int max2 = Max(a2, b2,c2);
int max3 = Max(a3, b3,c3);
int max = Max(max1, max2, max3);*/

/*int max = Max(
Max(a1, b1, c1),
Max(a2, b2, c2),
Max(a3, b3, c3));*/



/*Console.WriteLine(max);*/



/*if(b1 > max ) max = b1;
if(c1 > max ) max = c1;


if(a2 > max ) max = a2;
if(b2 > max ) max = b2;
if(c2 > max ) max = c2;

if(a3 > max ) max = a3;
if(b3 > max ) max = b3;
if(c3 > max ) max = c3;*/

