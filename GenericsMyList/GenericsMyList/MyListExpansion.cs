namespace GenericsMyList
{
    public static class MyListExpansion
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            var tempArray = new T[list.Count];
            for (var i = 0; i < list.Count; i++)
            {
                tempArray[i] = list[i];
            }

            return tempArray;
        }
    }
}
