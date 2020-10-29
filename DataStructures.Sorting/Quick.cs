namespace DataStructures.Sorting {

    public static class Quick {

        public static int[] QuickSort(this int[] collection) {
            QuickSort(collection, 0, collection.Length - 1);
            return collection;
        }

        private static void QuickSort(
            int[] collection,
            int start,
            int end) {
            if (start >= end) {
                return;
            }

            int pivot = Partition(collection, start, end);
            QuickSort(collection, start, pivot - 1);
            QuickSort(collection, pivot + 1, end);
        }

        private static int Partition(int[] collection, int start, int end) {
            int pivot = collection[end];
            int i = start - 1;

            for (int j = start; j < end; j++) {
                if (collection[j] <= pivot) {
                    i += 1;
                    int temp = collection[i];
                    collection[i] = collection[j];
                    collection[j] = temp;
                }
            }

            int temp1 = collection[i + 1];
            collection[i + 1] = collection[end];
            collection[end] = temp1;

            return i + 1;
        }
    }
}