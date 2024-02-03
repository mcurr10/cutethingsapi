internal class Program
{
    private static global::System.Int32 Main(string[] args)
    {
        exports.handler = function(context, event, callback) {
            console.log(`Incoming message: ${event.Body}`);
            // Here's an example of setting up some TWiML to respond to with this function
            const twiml = new Twilio.twiml.MessagingResponse();
            twiml.message("Thanks for your submission! 📸");
            console.log(`TwiML was ${ twiml}`);
            // This callback is what is returned in response to this function being invoked.
            // It's really important! E.g. you might respond with TWiML here for a voice or SMS response.
            // Or you might return JSON data to a studio flow. Don't forget it!
            return callback(null, twiml);
        };
    }
}