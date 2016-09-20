// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;


    /// <summary>
    /// Extension methods for Conversations.
    /// </summary>
    public static partial class ConversationsExtensions
    {
        /// <summary>
        /// CreateConversation
        /// </summary>
        /// Create a new Conversation.
        /// 
        /// POST to this method with a
        /// * Bot being the bot creating the conversation
        /// * IsGroup set to true if this is not a direct message (default is false)
        /// * Members array contining the members you want to have be in the
        /// conversation.
        /// 
        /// The return value is a ResourceResponse which contains a conversation id
        /// which is suitable for use
        /// in the message payload and REST API uris.
        /// 
        /// Most channels only support the semantics of bots initiating a direct
        /// message conversation.  An example of how to do that would be:
        /// 
        /// ```
        /// var resource = await connector.conversations.CreateConversation(new
        /// ConversationParameters(){ Bot = bot, members = new ChannelAccount[] { new
        /// ChannelAccount("user1") } );
        /// await connect.Conversations.SendToConversationAsync(resource.Id, new
        /// Activity() ... ) ;
        /// 
        /// ```
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='parameters'>
        /// Parameters to create the conversation from
        /// </param>
        public static ResourceResponse CreateConversation(this IConversations operations, ConversationParameters parameters)
        {
            return Task.Factory.StartNew(s => ((IConversations)s).CreateConversationAsync(parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// CreateConversation
        /// </summary>
        /// Create a new Conversation.
        /// 
        /// POST to this method with a
        /// * Bot being the bot creating the conversation
        /// * IsGroup set to true if this is not a direct message (default is false)
        /// * Members array contining the members you want to have be in the
        /// conversation.
        /// 
        /// The return value is a ResourceResponse which contains a conversation id
        /// which is suitable for use
        /// in the message payload and REST API uris.
        /// 
        /// Most channels only support the semantics of bots initiating a direct
        /// message conversation.  An example of how to do that would be:
        /// 
        /// ```
        /// var resource = await connector.conversations.CreateConversation(new
        /// ConversationParameters(){ Bot = bot, members = new ChannelAccount[] { new
        /// ChannelAccount("user1") } );
        /// await connect.Conversations.SendToConversationAsync(resource.Id, new
        /// Activity() ... ) ;
        /// 
        /// ```
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='parameters'>
        /// Parameters to create the conversation from
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<ResourceResponse> CreateConversationAsync(this IConversations operations, ConversationParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.CreateConversationWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return await _result.HandleErrorAsync<ResourceResponse>().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// SendToConversation
        /// </summary>
        /// This method allows you to send an activity to a conversation regardless of
        /// previous posts to a conversation.
        /// 
        /// This is slightly different then ReplyToConversation().
        /// * SendToConverstion(conversationId) - will simply append a message to the
        /// end of the conversation according to the timestamp or semantics of the
        /// channel
        /// * ReplyToActivity(conversationId,ActivityId) - models the semantics of
        /// threaded conversations, meaning it has the information necessary for the
        /// channel to reply to the actual message being responded to.
        /// 
        /// SendToConversation is appropriate for the first message which initiates a
        /// conversation, or if you don't have a particular activity you are
        /// responding to.
        /// 
        /// ReplyToActivity is preferable to SendToConversation() because it maintains
        /// threaded conversations.
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='activity'>
        /// Activity to send
        /// </param>
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        public static ResourceResponse SendToConversation(this IConversations operations, Activity activity, string conversationId)
        {
            return Task.Factory.StartNew(s => ((IConversations)s).SendToConversationAsync(activity, conversationId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// SendToConversation
        /// </summary>
        /// This method allows you to send an activity to a conversation regardless of
        /// previous posts to a conversation.
        /// 
        /// This is slightly different then ReplyToConversation().
        /// * SendToConverstion(conversationId) - will simply append a message to the
        /// end of the conversation according to the timestamp or semantics of the
        /// channel
        /// * ReplyToActivity(conversationId,ActivityId) - models the semantics of
        /// threaded conversations, meaning it has the information necessary for the
        /// channel to reply to the actual message being responded to.
        /// 
        /// SendToConversation is appropriate for the first message which initiates a
        /// conversation, or if you don't have a particular activity you are
        /// responding to.
        /// 
        /// ReplyToActivity is preferable to SendToConversation() because it maintains
        /// threaded conversations.
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='activity'>
        /// Activity to send
        /// </param>
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<ResourceResponse> SendToConversationAsync(this IConversations operations, Activity activity, string conversationId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.SendToConversationWithHttpMessagesAsync(activity, conversationId, null, cancellationToken).ConfigureAwait(false))
            {
                return await _result.HandleErrorAsync<ResourceResponse>().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// UpdateActivity
        /// </summary>
        /// This method allows you to edit an existing activity.
        /// 
        /// Some channels allow you to edit an existing activity to reflect the new
        /// state of a bot conversation.
        /// 
        /// For example, you can remove buttons after someone has clicked "Approve"
        /// button.
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        /// <param name='activityId'>
        /// activityId to update (OPTIONAL)
        /// </param>
        /// <param name='activity'>
        /// replacement Activity
        /// </param>
        public static ResourceResponse UpdateActivity(this IConversations operations, string conversationId, string activityId, Activity activity)
        {
            return Task.Factory.StartNew(s => ((IConversations)s).UpdateActivityAsync(conversationId, activityId, activity), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// UpdateActivity
        /// </summary>
        /// This method allows you to edit an existing activity.
        /// 
        /// Some channels allow you to edit an existing activity to reflect the new
        /// state of a bot conversation.
        /// 
        /// For example, you can remove buttons after someone has clicked "Approve"
        /// button.
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        /// <param name='activityId'>
        /// activityId to update (OPTIONAL)
        /// </param>
        /// <param name='activity'>
        /// replacement Activity
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<ResourceResponse> UpdateActivityAsync(this IConversations operations, string conversationId, string activityId, Activity activity, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.UpdateActivityWithHttpMessagesAsync(conversationId, activityId, activity, null, cancellationToken).ConfigureAwait(false))
            {
                return await _result.HandleErrorAsync<ResourceResponse>().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// ReplyToActivity
        /// </summary>
        /// This method allows you to reply to an activity.
        /// 
        /// This is slightly different then SendToConversation().
        /// * SendToConverstion(conversationId) - will simply append a message to the
        /// end of the conversation according to the timestamp or semantics of the
        /// channel
        /// * ReplyToActivity(conversationId,ActivityId) - models the semantics of
        /// threaded conversations, meaning it has the information necessary for the
        /// channel to reply to the actual message being responded to.
        /// 
        /// ReplyToActivity is almost always preferable to SendToConversation()
        /// because it maintains threaded conversations.
        /// 
        /// SendToConversation is appropriate for the first message which initiates a
        /// conversation, or if you don't have a particular activity you are
        /// responding to.
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        /// <param name='activityId'>
        /// activityId the reply is to (OPTIONAL)
        /// </param>
        /// <param name='activity'>
        /// Activity to send
        /// </param>
        public static ResourceResponse ReplyToActivity(this IConversations operations, string conversationId, string activityId, Activity activity)
        {
            return Task.Factory.StartNew(s => ((IConversations)s).ReplyToActivityAsync(conversationId, activityId, activity), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// ReplyToActivity
        /// </summary>
        /// This method allows you to reply to an activity.
        /// 
        /// This is slightly different then SendToConversation().
        /// * SendToConverstion(conversationId) - will simply append a message to the
        /// end of the conversation according to the timestamp or semantics of the
        /// channel
        /// * ReplyToActivity(conversationId,ActivityId) - models the semantics of
        /// threaded conversations, meaning it has the information necessary for the
        /// channel to reply to the actual message being responded to.
        /// 
        /// ReplyToActivity is almost always preferable to SendToConversation()
        /// because it maintains threaded conversations.
        /// 
        /// SendToConversation is appropriate for the first message which initiates a
        /// conversation, or if you don't have a particular activity you are
        /// responding to.
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        /// <param name='activityId'>
        /// activityId the reply is to (OPTIONAL)
        /// </param>
        /// <param name='activity'>
        /// Activity to send
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<ResourceResponse> ReplyToActivityAsync(this IConversations operations, string conversationId, string activityId, Activity activity, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ReplyToActivityWithHttpMessagesAsync(conversationId, activityId, activity, null, cancellationToken).ConfigureAwait(false))
            {
                return await _result.HandleErrorAsync<ResourceResponse>().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// GetConversationMembers
        /// </summary>
        /// Call this method to enumerate the members of a converstion.
        /// 
        /// This REST API takes a ConversationId and returns an array of
        /// ChannelAccount[] objects
        /// which are the members of the conversation.
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        public static ChannelAccount[] GetConversationMembers(this IConversations operations, string conversationId)
        {
            return Task.Factory.StartNew(s => ((IConversations)s).GetConversationMembersAsync(conversationId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// GetConversationMembers
        /// </summary>
        /// Call this method to enumerate the members of a converstion.
        /// 
        /// This REST API takes a ConversationId and returns an array of
        /// ChannelAccount[] objects
        /// which are the members of the conversation.
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<ChannelAccount[]> GetConversationMembersAsync(this IConversations operations, string conversationId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetConversationMembersWithHttpMessagesAsync(conversationId, null, cancellationToken).ConfigureAwait(false))
            {
                return await _result.HandleErrorAsync<ChannelAccount[]>().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// GetActivityMembers
        /// </summary>
        /// Call this method to enumerate the members of an activity.
        /// 
        /// This REST API takes a ConversationId and a ActivityId, returning an array
        /// of ChannelAccount[] objects
        /// which are the members of the particular activity in the conversation.
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        /// <param name='activityId'>
        /// Activity ID
        /// </param>
        public static ChannelAccount[] GetActivityMembers(this IConversations operations, string conversationId, string activityId)
        {
            return Task.Factory.StartNew(s => ((IConversations)s).GetActivityMembersAsync(conversationId, activityId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// GetActivityMembers
        /// </summary>
        /// Call this method to enumerate the members of an activity.
        /// 
        /// This REST API takes a ConversationId and a ActivityId, returning an array
        /// of ChannelAccount[] objects
        /// which are the members of the particular activity in the conversation.
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        /// <param name='activityId'>
        /// Activity ID
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<ChannelAccount[]> GetActivityMembersAsync(this IConversations operations, string conversationId, string activityId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetActivityMembersWithHttpMessagesAsync(conversationId, activityId, null, cancellationToken).ConfigureAwait(false))
            {
                return await _result.HandleErrorAsync<ChannelAccount[]>().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// UploadAttachment
        /// </summary>
        /// This method allows you to upload an attachment directly into a channels
        /// blob storage.
        /// 
        /// This is useful because it allows you to store data in a compliant store
        /// when dealing with enterprises.
        /// 
        /// The response is a ResourceResponse which contains an AttachmentId which is
        /// suitable for using with the attachments api.
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        /// <param name='attachmentUpload'>
        /// Attachment data
        /// </param>
        public static ResourceResponse UploadAttachment(this IConversations operations, string conversationId, AttachmentData attachmentUpload)
        {
            return Task.Factory.StartNew(s => ((IConversations)s).UploadAttachmentAsync(conversationId, attachmentUpload), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// UploadAttachment
        /// </summary>
        /// This method allows you to upload an attachment directly into a channels
        /// blob storage.
        /// 
        /// This is useful because it allows you to store data in a compliant store
        /// when dealing with enterprises.
        /// 
        /// The response is a ResourceResponse which contains an AttachmentId which is
        /// suitable for using with the attachments api.
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        /// <param name='attachmentUpload'>
        /// Attachment data
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<ResourceResponse> UploadAttachmentAsync(this IConversations operations, string conversationId, AttachmentData attachmentUpload, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.UploadAttachmentWithHttpMessagesAsync(conversationId, attachmentUpload, null, cancellationToken).ConfigureAwait(false))
            {
                return await _result.HandleErrorAsync<ResourceResponse>().ConfigureAwait(false);
            }
        }

    }
}
