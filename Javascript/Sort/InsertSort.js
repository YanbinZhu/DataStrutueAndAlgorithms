// insert sort

var insert = function (array, rightIndex, value) {

    var key;

    for (key = rightIndex; key > -1 && array[key] > value; key--) {
        array[key + 1] = array[key];
    }
    array[key + 1] = value;
};

var insertionSort = function (array) {

    for (var i = 1; i < array.length; i++) {
        insert(array, i - 1, array[i]);
    }
};
