#if DEBUG
int start = 0;
int end = 10;
int increase = 1;
#endif

#if RELEASE
int start = 0;
int end = 20;
int increase = 1
#endif

for (int i = start; i <= end; i += increase)
{
    Console.WriteLine(i);
}