public class Solution {
    public IList < int > GetRow(int rowIndex) {

        var arr = [];

        arr.push(1);

        for (var i = 1; i <= rowIndex; i++) {
            arr.push(0);
            for (var j = i; j > 0; j--)
                arr[j] = arr[j] + arr[j - 1];
        }
        return arr;

    }
}