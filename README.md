# AWS WebApi Deployment

This is a really quick dive into AWS to gain a little experience, I'm loving what I see so far!
Cloudformation seems to be the "docker-compose" of infrastructure and basic configs are 
quick to stand up

# What does this app do?

Well, it's a buzzword compliant microservice application that reads a single row
from a MySQL database and returns it to the user. I hope someone will recognise
this work and buy me out before I get to fortune 500 ;-)

# How automatic is it?

Not terribly at the moment! The inf stands itself up with the AWS cli (cloudformation,
docker daemon install, user groups), but deployments are currently limited to scp tar
deploys and manual database initialisation.

# That's naff, do you like SCP'ing onto boxes?

No, not at all, it's really grotty. But this repo is about earning CloudFormation
and I've decided to simplify some areas for the sake of enjoying my public holiday!

# Where would you go from here?

I'd extend the cloudformation `stack.yml` to include a configured ECS instance and
push the docker container to that in order to not have to build on the same machine.

This would get pushed through some pipeline.

Then the deployment could be automated with a simple pipeline script, 
leveraging the docker compose file as we do not need large orchestration with this demo app.

The other thing I would like to do would be automate the DB setup.
This could be done likely with a simple SQL script on instance startup, as a first
iterative approach, and then reworked into a separate "more solid" deployment
means if it grew (Flywheel, redgate, db snapshots etc)

# Have you left these instances running with the passwords available publicly via this repo?

Nope, feel free to try it