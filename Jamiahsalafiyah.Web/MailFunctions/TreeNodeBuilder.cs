using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using OpenPop.Mime;
using OpenPop.Mime.Traverse;
using Message = OpenPop.Mime.Message;
using System.Web.UI.WebControls;

namespace ProjectRCS.MailFunctions
{
    internal class TreeNodeBuilder : IAnswerMessageTraverser<TreeNode>
    {
        public TreeNode VisitMessage(Message message)
        {
            if (message == null)
                throw new ArgumentNullException("message");

            // First build up the child TreeNode
            TreeNode child = VisitMessagePart(message.MessagePart);

            // Then create the topmost root node with the subject as text
            TreeNode topNode = new TreeNode(message.Headers.Subject, child.ToString());

            return topNode;
        }

        public TreeNode VisitMessagePart(MessagePart messagePart)
        {
            if (messagePart == null)
                throw new ArgumentNullException("messagePart");

            // Default is that this MessagePart TreeNode has no children
            TreeNode[] children = new TreeNode[0];

            if (messagePart.IsMultiPart)
            {
                // If the MessagePart has children, in which case it is a MultiPart, then
                // we create the child TreeNodes here
                children = new TreeNode[messagePart.MessageParts.Count];

                for (int i = 0; i < messagePart.MessageParts.Count; i++)
                {
                    children[i] = VisitMessagePart(messagePart.MessageParts[i]);
                }
            }

            // Create the current MessagePart TreeNode with the found children
            TreeNode currentNode = new TreeNode(messagePart.ContentType.MediaType, children.ToString());

            // Set the Tag attribute to point to the MessagePart.
           // currentNode.Tag = messagePart;

            return currentNode;
        }
    }
}