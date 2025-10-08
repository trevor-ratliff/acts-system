# Notes from Trevor Ratliff on the BAM tech exercise

## Interview Notes

### API (required)

1. (x) Retrieve a person by name.
1. (x) Retrieve all people.
1. (x) Add/update a person by name.
	1. added `UpdatePerson` command along with `PUT` endpoint in the `PersonController`
1. (x) Retrieve Astronaut Duty by name. (x)
1. (x) Add an Astronaut Duty. (x)


### UI is expected to do the following: (encouraged)

1. Successfully implement a web application that demonstrates production level quality. Angular is preferred.
1. Implement call(s) to retrieve an individual's astronaut duties.
1. Display the progress of the process and the results in a visually sophisticated and appealing manner.

- I wanted to create a timeline control to display astronaut data in a "scrollable" window with a configurable pane
	- as you scroll right the year/months advance displaying Astronaut duty date in the working pane
	- as you get close to either edge a method call could be made to collect more data and render the html elements
		- data would be cached locally in localstorage or IndexDB
		- if the requested data is outside that range an api call could be made to get more
		- a data loading indicator would display in the lower right quadrant while data is loading
	- data that falls out of the pane is culled along with html elements to save memory in the page
	- either special coding on the scrollbar or a dragable div could scroll the pane as could clicking and dragging
	- hovering over a "bar" of data would show the austronaut duty details
	- hovering over the name of the astronaut on the side of the pane would get the austronaut details
		- clicking the name would scope the timeline/data table to that astronaut
	- timeline controll would be composed of a 
		- flexbox div (timeline) in the column layout 
		- with flexbox divs (months) in row layout representing a column of month data
			- data would be an alphabetized list of austronauts that had an active duty in that month
- I would have a paginated table of data below the timeline as well for displaying the scoped data.
	- 

### Tasks from assignment

Examine the code, find and resolve any flaws, if any exist. Identify design patterns and follow or change them. Provide fix(es) and be prepared to describe the changes.

1. Generate the database
    * This is your source and storage location
1. Enforce the rules
    - **added code in the prehandler** to filter out bad data for `UpdatePerson` commands
    - ___need to still verify___ other commands with unit tests and prehandlers
1. Improve defensive coding
    - ___didn't get to this___
1. Add unit tests
    * identify the most impactful methods requiring tests
        - **command classes** (like I did in `UpdatePerson_tests.cs`)
        - ___controllers___ http methods
    * reach >50% code coverage
        - ___I didn't have enough time___ to get to 50% coverage
1. Implement process logging
    * Log exceptions
    * Log successes
    - ___I wasn't able to get to this___, but planned on using MediatR's notification messages to send log messages
1. **Patterns used**
    - repository pattern
    - command pattern
    - mediator pattern


### known issues

#### secruity
	- add an oath provider/service such as Identity Server 4
	- have application token for the web ui to access the api
	- require authentication on writting endpoints at least (PUT, POST, etc.)

#### scalability
    - may need cache for get endpoints in API
    - create a command queue for batching/throttling for multiple instances of the API
    - maybe think about splitting API into serverless funcitons (AWS llambda for instance) using load balancer to keep API layout, while passing work to the correct auto scaling serverless function if the site starts getting lots of traffic
    - add pagination to API calls ???


## log

### 2025-10-03
- opened up the project to look at the exercise files
- set up .net sdk and other build tools
- tried using qwen3 in agent mode to initialize an angular app ... didn't work so well
- will clean up the mess then try again on Monday.

### 2025-10-04
- plans changed, I am doing more work today.  I've been thinking about the overall plan
- organized thoughts, and notes for tracking tasks
- started getting dev environment ready for work (needed .net sdks, and EF tools)
- got db generated, committed changes to git

### 2025-10-06
- started working on changes as I think I have plans laid
- started adding feature to change person name
- started adding unit tests (got some working)
- need to add more documentation around ideas ...

### 2025-10-07
- checking code coverage so far - should be really low
- got more unit test done for new feature UpdatePerson 
- added more notes about plans in case I can't get more done
- 