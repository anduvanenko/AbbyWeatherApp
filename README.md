# AbbyWeatherApp
Weather website

UPDATE:
Created branch JSONChanges (have github linked up with sourcetree to visually see changes/branches better)
I updated all of the c# code that I didn't need for now for json parsing. commented it out, will clean up.
Just pushing for now since I can now input any state and city in without issues (that I know of so far).
going to work on error handling down the road if there is no input, etc.

UPDATE 2:
created another branch, weatherUpdates
had daily, hourly, mulitday pull better data down
still working on fixing multiday because one of the labels isn't working right for high and low temperatures
still working on adding which days are nice for the week
have some other adjustments I want to do but otherwise focusing on functionality of project


Apologize in advance for the essay, but I wanted to make sure my thought process was put out there and everything I would do different on this project seeing how I started the project a bit late this week on top of working full time. Also I do relate a lot of my life and random topics throughout it. Just so my personality shows a bit more throughout this :D


The way I started this project out was searching for a weather API. I knew I needed to find one with the right requirements for the project.

I was working on breaking up the project into manageable chunks of code to work with. If I didn't get an API working, I knew that I wouldn't be able to make much progress on the functionality of the project.

I wanted to find one that was in XML but I figured I could learn a little more by doing JSON with this API. 

Here's the link to the API I used: https://www.wunderground.com/weather/api/

Also I have the key hardcoded in the project so then it should work for any who tries the project. I want to fix that later on so then it isn’t that way but for now it worked to show the project off.

The wunderground API also does have XML but I figured it would be a good learning time since I used a tiny bit of it in school, so it's been a while since I've touched JSON.

The next step was how I wanted to implement the API. I knew I would have to do parsing for it into my web project. But the main thing I needed to decide was what would I use to build out my project.

I figured I would do android, but then I couldn't get the android app to work properly in visual studio. (As side note, visual studio is generally my go to for projects with web design since it has a lot of ways you can build out a website or just projects in general. EX: webforms, MVC, etc) 

The reason I decided against android is that I wanted to get the functionality down for the project so I could turn the project in at a decent time. I still want to learn android but figured I would try something I am more familiar with so I could get everything working right and turned in on time since I started this project late. Reasons for starting late is I was still unsure about my decision for the company.

I decided to go with a webform in visual studio. I was already pretty familiar with it, so I figured for getting the project the way I envisioned it to be, this would be the best option.

Down the road I am so updating this website to something new and fun! So to me this is just iteration 1 of the project, minus android not working :)

So the webforms were working for me, besides the JSON parsing. I was struggling getting that to work since it was passing in null values. I started realizing that I needed to have some c# code to pass in the json into objects after some errors in my code and later the JSON parsing. I wrote some c# and realized from prior experience that it would be easier to use json to c# converter. That way it saves me time to write c# and I know it gets the code right, mostly since I forgot JSON is hierarchy based. 

I went through a ton of testing to make sure the websites for the API were working, so I had some hardcoded json printing out in labels. I was confused as to why having it hardcoded was working and why it couldn’t grab the json from the url I had. That’s when I did more research and realized that it was me forgetting that JSON is hierarchy based. 

Also one of the best things with coding, is that sometimes you need to leave your work after sometime to let your brain catch up. It’s like jigsaw puzzles (one of my favorite hobbies), sometimes you need to see it from a new perspective/angle. So taking a break by going to get food, sleep or whatever it is, by the time you come back to the project you may see it from a different angle/perspective and realize some little thing you forgot about, or some little piece you didn’t see before or some better research is all you needed. 

I love referring to jigsaw puzzles to software engineering since I have done those since I was very young. I was always too stubborn to give up since I wanted to see the final result of my hard work. I still continue doing puzzles to this day, a lot being video game related puzzles that I am glueing so I can frame them and will have in my own personal game room (since I want a gaming room and don't have one yet).

My choice over the JSON problem was to take a step back and get some sleep, and I realized the next day that it was hierarchy based.

Once I realized that JSON was hierarchy based, my values were now being parsed through correctly to C# and into the labels. I had to have the hierarchy written out in the code and know how it worked in JSON to be able to have it print in the label. I now worked on fixing up the code to not be hardcoded and more flexible to the users input. Which ended up being more of the website design. 

With the input design, I realized that my input for state and city (because that’s how the api works), that it only takes in ‘IN, Carmel’. I was trying other cities in indiana and my code throws errors. So I need to figure out why that is and improve it. My first thought is because I pulled carmel data down for the json to be converted to c#. But I also am thining some of it might be null or have some other value that is causing the error, example being string to int or something like that causing the issue. So I’m going to dig around more to see if I can figure out the issue.

Also with it pulling data down from JSON, I want to make an improvement for error handling, if there a JSON part that is null or missing, I want my code to be able to handle that. I wasn’t able to implement it now but I do want to point out it is one of the thoughts I had while working on the project.

Trust me, that website is as plain and boring as you can have it. If I had more time I would pretty it up so it wouldn’t look the way it is. I went for functionality for the time I had left. Since I had a ton of fun doing this project, I think I’m going to continue working on it so I make it more pretty and actually have an appealing look along with some other fun features!

There are so many features I would add too. I would have the labels hidden so you don’t see them until all the information is found. I would make it where the website has error handling and notifies you if you don’t have an input in the textbox. I would actually change the design so it isn’t textboxes and be the drop down box, or on iOS devices the scroll wheel thing. That way you can pick a state in the US and then it’ll show the cities from that state in another scroll wheel/drop down box. I would add pictures that described the weather, like clear, sunny, snowy, etc. That way you aren’t just reading text. I would do better error handling too.

Another improvement I saw while working on this project is the hierarchy. I want to somehow get that working with for loops through an array because of how JSON works. I am still working on implementing that because it it just too repetitive to go down the hierarchy myself just to get different parts of the weather I wanted outputted in the label. Mostly for having 7 days, I don’t want to grab each day and write out all that code just for 1 day and do it 7 times. That’s what for loops help with.

Since I started a bit late doing the project, there are a lot of features I would implement differently knowing I should have tried planning this out a little better. Software can be continually improved upon and I kept doing that while working. I also didn't want to get too caught up on fixing it continually since I really wanted to get the functionality down before improving it a lot more. I would think of a new way to improve the project and one that I love is string.format. I love that I can use concatenation but recently I found out about string.format. So it makes it so much cleaner to read and figure out where each variable will be placed into the code you have. I still want to continue to make this project better but functionality for now was my main goal. Design and fixing up comes later on since you want to make sure stuff works rather than having something pretty and nothing works.

Now I know I didn’t hit all the requirements for the project, but I decided to go with what I thought would be best to implement in the time I had to work on it. I still want to continue updating it after everyone sees it so then I can improve on my skills, plus I just had way too much fun working on this project that I want to see how much I can improve it!

Also I tried cleaning it up so then it would be more to clean code standards where there isn’t white space or comments. My code could use a lot more improvement so then it’s easier to figure out what each part is doing, plus I know there are ways I personally want to improve it. I know I still have a lot to learn with clean code since I only remember certain parts of that book.


