

var workStartTime = new TimeOnly(9, 0);
var workEndTime = new TimeOnly(14, 45);

var meetingStartTimes = new DateTime[10];
meetingStartTimes[0] = new DateTime(2023, 04, 21, 14, 18, 15);
meetingStartTimes[1] = new DateTime(2023, 11, 21, 9, 35, 45);
meetingStartTimes[2] = new DateTime(2023, 12, 29, 23, 56, 59);
meetingStartTimes[3] = new DateTime(2023, 09, 08, 17, 43, 24);
meetingStartTimes[4] = new DateTime(2023, 10, 18, 9, 15, 45);
meetingStartTimes[5] = new DateTime(2023, 07, 26, 15, 45, 15);
meetingStartTimes[6] = new DateTime(2023, 01, 19, 22, 10, 47);
meetingStartTimes[7] = new DateTime(2023, 08, 17, 17, 17, 17);
meetingStartTimes[8] = new DateTime(2023, 03, 30, 12, 10, 45);
meetingStartTimes[9] = new DateTime(2023, 09, 1, 6, 19, 37);

var meetingEndTime = new TimeSpan[10];
meetingEndTime[0] = TimeSpan.FromMinutes(20);
meetingEndTime[1] = TimeSpan.FromMinutes(45);
meetingEndTime[2] = TimeSpan.FromMinutes(19);
meetingEndTime[3] = TimeSpan.FromMinutes(29);
meetingEndTime[4] = TimeSpan.FromMinutes(37);
meetingEndTime[5] = TimeSpan.FromMinutes(68);
meetingEndTime[6] = TimeSpan.FromMinutes(78);
meetingEndTime[7] = TimeSpan.FromMinutes(54);
meetingEndTime[8] = TimeSpan.FromMinutes(18);
meetingEndTime[9] = TimeSpan.FromMinutes(37);


Console.WriteLine("30 daqiqadan oshadigan meetinglar: ");

for(int i = 0; i < meetingEndTime.Length; i++)
{
    if (meetingEndTime[i].TotalMinutes > 30)
    {
        Console.WriteLine(meetingEndTime[i]);
    }
}

Console.WriteLine("Umumiy meetinglar qancha vaqt olishlari: ");
int sum = 0;
for(int j = 0; j < meetingEndTime.Length; j++)
{
    sum += meetingEndTime[j].TotalMinutes;
}
Console.WriteLine(sum);