namespace DataStructures.Sorting {

    public static class Insertion {

        public static int[] InsertionSort(this int[] collection) {
            for (int i = 1; i < collection.Length; i++) {
                int currentNumber = collection[i];

                while (i > 0 && collection[i - 1] > currentNumber) {
                    collection[i] = collection[i - 1];
                    i -= 1;
                }

                collection[i] = currentNumber;
            }

            return collection;
        }
    }
}