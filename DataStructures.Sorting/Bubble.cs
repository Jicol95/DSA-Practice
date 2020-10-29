using System.Linq;

namespace DataStructures.Sorting {

    public static class Bubble {

        public static int[] BubbleSort(this int[] collection) {
            int length = collection.Length;

            for (int i = 0; i < length - 1; i++) {
                for (int j = i + 1; j < length; j++) {
                    if (collection[j] < collection[i]) {
                        int temp = collection[i];
                        collection[i] = collection[j];
                        collection[j] = temp;
                    }
                }
            }

            return collection;
        }
    }
}