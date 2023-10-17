// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

float sophia = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / currentAssignments;

Console.WriteLine(sophia);
float AddUp(params int[] values)
{
    int sum = 0;
    foreach (int value in values)
    {
        sum += value;
    }
    float result = sum / currentAssignments;
    return result;
}

Console.WriteLine(AddUp(sophia1, sophia2, sophia3, sophia4, sophia5));
Console.WriteLine(AddUp(nicolas1, nicolas2, nicolas3, nicolas4, nicolas5));
Console.WriteLine(AddUp(zahirah1, zahirah2, zahirah3, zahirah4, zahirah5));
Console.WriteLine(AddUp(jeong1, jeong2, jeong3, jeong4, jeong5));

