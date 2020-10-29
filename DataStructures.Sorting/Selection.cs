namespace DataStructures.Sorting {

    public static class Selection {

        public static int[] SelectionSort(this int[] collection) {
            int length = collection.Length;

            for (int i = 0; i < length; i++) {
                int minIndex = i;

                for (int j = i + 1; j < length; j++) {
                    if (collection[j] < collection[minIndex]) {
                        minIndex = j;
                    }
                }

                int temp = collection[i];
                collection[i] = collection[minIndex];
                collection[minIndex] = temp;
            }

            return collection;
        }
    }
}