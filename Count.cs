namespace CountExample
{
    class Count
    {
        private int count = 0;
        private int min;
        private int max;


        // Khởi tạo hàm đếm với min-max (min, max)
        public Count(int min, int max)
        {
            this.min = min;
            this.max = max;
        }


        // Khởi tạo hàm đếm với ngưỡng (-threshold, threshold)
        public Count(int threshold)
        {
            this.min = -threshold;
            this.max = threshold;
        }

        // Hàm tăng giá trị
        public void Increasing()
        {
            if (count >= max)
            {
                Console.WriteLine("Không thể tăng được nữa");
                return;
            }
            count++;
            DisplayCount();
        }


        // Hàm giảm giá trị
        public void Decreasing()
        {
            if (count <= min)
            {
                Console.WriteLine("Không thể giảm được nữa");
                return;
            }
            count--;
            DisplayCount();
        }


        // Hàm hiển thị giá trị
        public void DisplayCount()
        {
            Console.WriteLine("Current count: " + count); 
        }


        // Hàm kiểm tra có thể thay đổi không
        public bool CanChange()
        {
            return !(count < min || count > max);
        }
    }
}