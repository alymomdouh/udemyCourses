namespace masteringCourseForProfessionals
{
    internal class Sample<T>
    {
        T field;
        public T Field
        {
            get
            {
                return field;
            }
            set
            {
                field = value;
            }
        }
        public string ShowInfo()
        {
            // return $"Type: {typeof(T).Name}, Value: {field}";
            return $"Type: {field.GetType()}, Value: {field}";
        }
    }
}
