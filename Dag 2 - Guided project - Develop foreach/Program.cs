using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;

int[] sophia_arr = new int[] {sophia1, sophia2, sophia3, sophia4, sophia5};

int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;

int[] andrew_arr = new int[] {andrew1, andrew2, andrew3, andrew4, andrew5};


int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;

int[] emma_arr = new int[] {emma1, emma2, emma3, emma4, emma5 };


int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;

int[] logan_arr = new int[] { logan1, logan2, logan3, logan4, logan5};




decimal sophiaScore = AddUp(sophia_arr);
decimal andrewScore = AddUp(andrew_arr);
decimal emmaScore = AddUp(emma_arr);
decimal loganScore = AddUp(logan_arr);

decimal AddUp(params int[] values)
{
    int sum = 0;
    foreach (int value in values)
    {
        sum += value;
    }
    decimal result = sum / currentAssignments;
    return result;
}


Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
