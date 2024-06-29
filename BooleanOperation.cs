class BooleanOperation
{
    public static bool SetAlarm(bool employed, bool vacation)
    {
        return employed && !vacation;
    }

    public static bool ArrowReturn(bool employed, bool vacation) => employed && !vacation;
}