# Technology Blog made with Contentful CMS

This is a task for school.

## Building the website local

Using docker

1. clone the repo
2. cd repo
3. `docker build . -t techblog
4. `docker run . -e "Contentfuloptions__DeliveryApiKey=<your token>"  -e "Contentfuloptions__ManagementApiKey=<optional cma_access_token>" -e "Contentfuloptions__PreviewApiKey=<your key>" -e "Contentfuloptions__SpaceId=<your space ID>" -e "Contentfuloptions__UsePreviewApi=false" -e "Contentfuloptions__MaxNumberOfRateLimitRetries=0" -p 8080:80 techblog`
5. access it at `http://localhost:8080`

You need to set all of the following env-variables:

## Developing/ running local

1. For development/ running the application locally you can put the ENV-values in the `.env` file at project root
2. `dotnet build .`
3. `dotnet run`

```bash
# This are the env-values place them in a .env file at project root
Contentfuloptions__DeliveryApiKey="<your token>"
Contentfuloptions__ManagementApiKey="<optional cma_access_token>"
Contentfuloptions__PreviewApiKey="<your key>"
Contentfuloptions__SpaceId="<your space ID>"
Contentfuloptions__UsePreviewApi=false
Contentfuloptions__MaxNumberOfRateLimitRetries=0
```

## TODO

- Application

  - Page with links to blog posts?
  - [ ] Categories? / filter system => TAGS
  - [ ] Search system? (MIGHT be hard, since none of the data is local. it's all in cms. Or just pure javascript on the rendered webpage, SEARCH QUERY IN CONTENTFUL?)

- Other
  - [x] Fix github actions
  - [x] Docker stuff for auto deployments with actions
  - !IMPORTNAT [ ] Don't leak API tokens!
