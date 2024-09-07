# The first laboratory of ITHS - 2024

## This first laboratory is about creating a Console App where some specifications are needed.

### The specifications for this specific laboratory is:

* Create a Console app where the user inputs a string.
    * Search the string if it has a integer who starts and ends at the with number
        * Mark all the characters in between <span style="color:red">RED</span>.
        * Else white.

    * If the string has a letter in between start integer and end integer, this is not a valid output.
        * 3463 is correct and will display span style="color:red">RED</span>.
        * 34363 is wrong since it should stop at the first 3.
        * 95a9 is not valid since it contains a letter.

    * Lastly, the substring marked red calculate the total of the numbers.

#### Example input string: "29535123p48723487597645723645"

#### Ouput:
- <span style="color:red">2953512</span>3p48723487597645723645
- 29<span style="color:red">535</span>123p48723487597645723645
- 295<span style="color:red">35123</span>p48723487597645723645
- 29535123p<span style="color:red">487234</span>87597645723645
- 29535123p4<span style="color:red">872348</span>7597645723645
- 29535123p48<span style="color:red">723487</span>597645723645
- 29535123p487<span style="color:red">2348759764572</span>3645
- 29535123p4872<span style="color:red">3487597645723</span>.645
- 29535123p48723<span style="color:red">48759764</span>5723645
- 29535123p4872348<span style="color:red">7597</span>645723645
- 29535123p48723487<span style="color:red">597645</span>723645
- 29535123p4872348759<span style="color:red">76457</span>23645
- 29535123p48723487597<span style="color:red">6457236</span>45
- 29535123p487234875976<span style="color:red">4572364</span>5
- 29535123p4872348759764<span style="color:red">5723645</span>


Total = 5836428677242




-----------------------------------
### Ducks are important. Here's one.


<picture>
  <source media="(prefers-color-scheme: dark)" srcset="PixelDuck.png">
  <img alt="PixelDuckling." >
</picture>