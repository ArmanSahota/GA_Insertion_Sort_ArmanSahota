# GA_Insertion_Sort_ArmanSahota

Static void insertion sort array (int[] array)

//insertion sor array (needs an array)
{
	int array length = array.length 
	//short way to get length of list

	for( int current index = 1; current index < array length; current index++)
//loop starts at the second index 
	
	{


        int current value = arr[current Index];
current value is saved in currentvalue integer

        int previous Index = current Index - 1;
previous index is saved

       
        while (previousIndex >= 0 && arr[previousIndex] > currentValue)
        {
while the previous index is greater than or equal to 0 and the previous index number itself is greater than the currentvalue

            arr[previousIndex + 1] = arr[previousIndex];
the index infront of the previous index is now the current previous index
   
         previousIndex = previousIndex - 1;
previous index is pushed back one
        }

       
        arr[previousIndex + 1] = currentValue;
    }
now the current value is infront of the previous value



}
