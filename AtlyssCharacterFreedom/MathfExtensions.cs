namespace AtlyssCharacterFreedom
{
    public static class MathfExtensions
    {
        public static float Remap(this float value, float inputMinimum, float inputMaximum, float outputMinimum, float outputMaximum)
        {
            return (value - inputMinimum) * (outputMaximum - outputMinimum) / (inputMaximum - inputMinimum) + outputMinimum;
        }
    }
}