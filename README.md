### C# application that calculates a customer bill for the city power company. 
* Calculation was done for one customer at a time. 
* The rates vary depending on the customer type: residential, commercial, or industrial: 
<ol>
<li>Residential: $6.00 plus $0.052 for each kWh used ($6.00 is charged even when kWh usage is zero) </li>
<li>Commercial: Flat rate of $60.00 for the first 1000 kWh used (or part of, even when zero), and $0.045 for each additional kWh </li>
<li>Industrial: Rate depends on whether usage occurred during peak hours or off-peak hours:</li> 
<ul>
<li>Peak hours: Flat rate of $76.00 for the first 1000 kWh used (or part of, even when zero), and $0.065 for each additional kWh</li> <li>Off-peak hours: Flat rate of $40.00 for the first 1000 kWh used (or part of, even when zero), and $0.028 for each additional kWh. </li> 
* Calculated bill amount for the customer should be displayed in currency format. 
* The application have three buttons: 
<ul>
<li>Calculate – triggers performing calculations. </li>
<li>Clear – erases input and output data in preparation for another calculation, and resets the controls to reflect the default residential customer type (as when the application starts) </li>
<li>Exit – terminates the application. </li>
<li>Validate user inputs to be non-negative whole numbers.</li>
