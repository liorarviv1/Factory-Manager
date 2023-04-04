
    async function countUserActions()
    {
        var today = new Date();
        var date = today.getDate();
        let useridd=localStorage.getItem("user ID")

        
        if(localStorage.getItem("count actions")>0 && localStorage.getItem("date is")==date)
        {
            let severalActions=localStorage.getItem("count actions")-1
            localStorage.setItem("count actions",severalActions)

            // let dayy=+localStorage.getItem("date is")
            // alert(severalActions)

            let obj={"NumOfActions" : localStorage.getItem("count actions"),
                     "DailyActions" : localStorage.getItem("date is")
                    };
                        
                    let fetchParams = { method  : 'PUT',
                                            body : JSON.stringify(obj),                        
                                        headers : {'Content-Type' : 'application/json'}
                        };

                        let resp = await fetch("https://localhost:44320/api/User/"+useridd,fetchParams)
                        let status=await resp.json(); 
                        // alert(status)
        }
        else if(localStorage.getItem("date is")!=date)
                {
                    let obj={"NumOfActions" : 29,
                            "DailyActions":date};
                        
                        let fetchParams = { method  : 'PUT',
                                            body : JSON.stringify(obj),                        
                                        headers : {'Content-Type' : 'application/json'}
                        };

                        let resp = await fetch("https://localhost:44320/api/User/"+localStorage.getItem("user ID"),fetchParams)
                        let status=await resp.json();
                        localStorage.setItem("date is",date)
                }
        
        else
        {
            window.location.href ="login.html"
            alert("You have exceeded the amount of operations for that day, please try again the next day")
        }
    }
