# dynamics365-share-js-sdk
Tela WebResource de compartilhamento do Dynamics 365 usando AngularJS e SDK em javascript

# How to use

                var pageInput = {
                    pageType: "webresource",
                    webresourceName: "new_html_compartilhar_registro",
                    data: JSON.stringify({ type: 'annotation', ids: [annotationid1, annotationid2] })
                };
                var navigationOptions = {
                    target: 2,
                    height: { value: 80, unit: "%" },
                    width: { value: 60, unit: "%" },
                    position: 1
                };
                parent.Xrm.Navigation.navigateTo(pageInput, navigationOptions);

# Screen

![image](https://user-images.githubusercontent.com/84979740/120002140-e313c000-bfaa-11eb-9f19-de019b5f602b.png)
