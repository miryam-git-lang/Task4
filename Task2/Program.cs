using System;

int numb = 25;
int i = 1;
bool check = false;

while (i < numb)
{
	i++;
	if (numb % i == 0)
	{
		check = true;
		break;
	}
}	

if (check == true)
{
	Console.WriteLine("reqem murekkebdir");
}
else
{	
	Console.WriteLine("reqem sadedir");
}

Console.ReadKey();




