namespace DataStructures.Sorting {

    public static class Merge {

        public static int[] MergeSort(this int[] collection) {
            int length = collection.Length;

            if (length < 2) {
                return collection;
            }

            int pivot = length / 2;
            int[] left = collection[0..pivot];
            int[] right = collection[pivot..^0];

            MergeSort(left);
            MergeSort(right);

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length) {
                if (left[i] < right[j]) {
                    collection[k] = left[i];
                    i += 1;
                } else {
                    collection[k] = right[j];
                    j += 1;
                }

                k += 1;
            }

            while (i < left.Length) {
                collection[k] = left[i];
                i += 1;
                k += 1;
            }

            while (j < right.Length) {
                collection[k] = right[j];
                j += 1;
                k += 1;
            }

            return collection;
        }
    }
}