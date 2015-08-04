var init = false;
function initProcessing() {
	var pjs = Processing.getInstanceById('mysketch');
    if(pjs != null) {
	    if(typeof(pjs.initialize) == "function") {	
	    	pjs.initialize(names,images);
	        init = true;
	    }
     }
     if(!init) setTimeout(initProcessing, 250); 
}
initProcessing();
