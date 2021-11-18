namespace WorkerService
{
    public class CAssignment
    {
        public CAssignment()
        {
            
        }

        public int[] duplicate(int[] list)
        {
            int len = list.Length;
            int[] result = new int[len * 2];
            for (int i = 0; i < len; i++)
            {
                result[i] = list[i];
                result[len + i] = list[i];
            }

            return result;
        }
    }
}