const mainContainer = document.querySelector('app-root') as HTMLElement
const images = {
  robot: 'blob:https://blogproject1764.file.core.windows.net/blogproject1764shares/robot-96.png',
  conversation: 'blob:https://blogproject1764.file.core.windows.net/blogproject1764shares/communication-96.png',
  close: 'blob:https://sandbox-91-13.reactblade.portal.azure.net/85e6f74a-96cc-4bc9-9ece-e8b98907d012'
}

// declare global {
  interface Window {
    tempImages: any
  }
// }

window.tempImages = images


// mainContainer.innerHTML = `
//   <div id="main-chat">
//     <div class="mc-options">
//       <div class="button-person-counseling-adviser">
//         <img class="img-person-counseling-adviser"  src="${images.robot}" />
//       </div>

//       <div class="button-full-conversation">
//         <img class="img-person-counseling-adviser"  src="${images.conversation}" />
//       </div>

//       <div class="button-minimize-chat">
//         <img class="img-close" src="${images.close}" />
//       </div>
//     </div>
//   </div>
// `