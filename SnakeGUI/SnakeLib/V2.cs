namespace SnakeLib
{
    public class V2<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public V2()
        {
            X = default(T);
            Y = default(T);
        }

        public V2(T x, T y)
        {
            X = x;
            Y = y;
        }
    }
}