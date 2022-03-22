// Bool
bool b = true;

// Numeric
short sh = -32768;
int i = 2147483647;
long l = 1234L;         // L suffix
float f = 123.45F;      //  F suffix
double d1 = 123.45; 
double d2 = 123.45D;    // D suffix
decimal d = 123.45M;    // M suffix

// Char/String
char c = 'A';
string s = "Hello";

// DateTime 2011-10-30 12:35
DateTime dt = new DateTime(2011,10,30,12,35,0);

// Max/Min
int i = int.MaxValue;
float f = float.MinValue;

// NULL
string s;
s = null;

// Nullable
int? i = null;
i = 101;

bool? b = null;

//int? 를 int로 할당
Nullable<int> j = null;
j = 10;
int k = j.value;