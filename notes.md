# Notes from Trevor Ratliff on the BAM tech exercise

## Interview Notes

### API (required)

1. Retrieve a person by name.
1. Retrieve all people.
1. Add/update a person by name.
1. Retrieve Astronaut Duty by name.
1. Add an Astronaut Duty.


### UI is expected to do the following: (encouraged)

1. Successfully implement a web application that demonstrates production level quality. Angular is preferred.
1. Implement call(s) to retrieve an individual's astronaut duties.
1. Display the progress of the process and the results in a visually sophisticated and appealing manner.


### Tasks from assignment

Examine the code, find and resolve any flaws, if any exist. Identify design patterns and follow or change them. Provide fix(es) and be prepared to describe the changes.

1. Generate the database
    * This is your source and storage location
1. Enforce the rules
1. Improve defensive coding
1. Add unit tests
    * identify the most impactful methods requiring tests
    * reach >50% code coverage
1. Implement process logging
    * Log exceptions
    * Log successes
1. Patterns used
    - repository pattern
    - 


### known issues

#### scalability
    - may need cache for get endpoints in API
    - create a request queue for throttling concerns
    - split API into serverless funcitons (AWS llambda for instance) using load balancer to keep API layout, while passing work to the correct auto scaling serverless function
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
- 