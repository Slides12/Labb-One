# The first laboratory of ITHS - 2024

## This first laboratory is about creating a Console App where some specifications are needed.

### The specifications for this specific laboratory is:

* Create a Console app where the user inputs a string.
    * Search the string if it has a integer who starts and ends at the with number
        * Mark all the characters in between **{\color{red}RED}**.
        * Else white.

    * If the string has a letter in between start integer and end integer, this is not a valid output.
        * 3463 is correct and will display **{\color{red}RED}**.
        * 34363 is wrong since it should stop at the first 3.
        * 95a9 is not valid since it contains a letter.

    * Lastly, the substring marked red calculate the total of the numbers.

#### Example input string: "29535123p48723487597645723645"

#### Ouput:
- ${\color{red}2953512}3p48723487597645723645$
- $29{\color{red}535}123p48723487597645723645$
- $295{\color{red}35123}p48723487597645723645$
- $29535123p{\color{red}487234}87597645723645$
- $29535123p4{\color{red}872348}7597645723645$
- $29535123p48{\color{red}723487}597645723645$
- $29535123p487{\color{red}2348759764572}3645$
- $29535123p4872{\color{red}3487597645723}645$
- $29535123p48723{\color{red}48759764}5723645$
- $29535123p4872348{\color{red}7597}645723645$
- $29535123p48723487{\color{red}597645}723645$
- $29535123p4872348759{\color{red}76457}23645$
- $29535123p48723487597{\color{red}6457236}45$
- $29535123p487234875976{\color{red}4572364}5$
- $29535123p4872348759764{\color{red}5723645}$


Total = 5836428677242




-----------------------------------
### Ducks are important. Here's yours.


<picture>
  <source media="(prefers-color-scheme: dark)" srcset="PixelDuck.png">
  <img alt="PixelDuckling." >
</picture>