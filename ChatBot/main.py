import Constants as Keys
from telegram.ext import *
import Responses as R

print("התחלנו")

def handle_message(update, context):
    text = str(update.message.text)

    response = R.sample_responses(text)

    update.message.reply_text(response)


def error(update, context):
    print(f"Update {update} caused error {context.error}")


def main():
    updater = Updater(Keys.API_KEY, use_context=True)
    dp = updater.dispatcher

    dp.add_handler(MessageHandler(Filters.text, handle_message))

    dp.add_error_handler(error)

    updater.start_polling()
    updater.idle()


main()
